using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RentTinyHouse
{
    public partial class FrmRent : Form
    {
        // Veritabanı bağlantı dizesi
        private const string ConnectionString = "Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;";

        // Günlük kiralama ücreti
        double DailyRate = 100.0; // Örnek değer, veritabanından çekilebilir

        public FrmRent()
        {
            InitializeComponent();
        }

        private void FrmRent_Load(object sender, EventArgs e)
        {
            // Başlangıç ayarları
            InitializeDatePickers();
            UpdateBalanceLabel();
            LoadAvailableHouses();
        }

        private void InitializeDatePickers()
        {
            dtpStart.Value = DateTime.Now;
            dtpEndDate.Value = dtpStart.Value.AddDays(1);
            dtpStart.MinDate = DateTime.Now;
            dtpEndDate.MinDate = dtpStart.Value.AddDays(1);
        }

        public void UpdateBalanceLabel()
        {
            lblMoney.Text = UserData.Money.ToString("0.00");
        }

        private void LoadAvailableHouses()
        {
            try
            {
                cmbHouses.Items.Clear();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    string query = "SELECT houseId, title FROM tblHouse WHERE isActive   = 1";
                    using (var cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbHouses.Items.Add(new HouseItem(
                                    (int)reader["houseId"],
                                    reader["title"].ToString()
                                ));
                            }
                        }
                    }
                }

                if (cmbHouses.Items.Count > 0)
                {
                    cmbHouses.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Kiralanabilir ev bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRent.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ev listesi yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmMain().Show();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPayment(this).Show();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStart.Value.AddDays(1);
            if (dtpEndDate.Value < dtpEndDate.MinDate)
            {
                dtpEndDate.Value = dtpEndDate.MinDate;
            }
            CalculatePrice();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            int days = (dtpEndDate.Value - dtpStart.Value).Days;
            if (days > 0)
            {
                double totalPrice = days * DailyRate;
                lblPrice.Text = $"Toplam Ücret: {totalPrice.ToString("0.00")}";
                lblPrice.Visible = true;
            }
            else
            {
                lblPrice.Visible = false;
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (cmbHouses.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ev seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedHouse = (HouseItem)cmbHouses.SelectedItem;
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEndDate.Value;

            if (!ValidateRentalDates(startDate, endDate))
                return;

            int days = (endDate - startDate).Days;
            double totalPrice = days * DailyRate;

            if (!CheckUserBalance(totalPrice))
                return;

            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Rezervasyon oluştur
                            int reservationId = CreateReservation(connection, transaction, selectedHouse.Id, startDate, endDate, totalPrice);

                            // Ödeme kaydı oluştur
                            CreatePayment(connection, transaction, reservationId, totalPrice);

                            // Bakiyeyi güncelle
                            UpdateUserBalance(totalPrice);

                            transaction.Commit();

                            MessageBox.Show("Kiralama işlemi başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            new FrmMain().Show();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Kiralama işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateRentalDates(DateTime startDate, DateTime endDate)
        {
            if (startDate >= endDate)
            {
                MessageBox.Show("Lütfen geçerli bir tarih aralığı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckUserBalance(double totalPrice)
        {
            if (UserData.Money < (decimal)totalPrice)
            {
                var result = MessageBox.Show("Yetersiz bakiye! Para eklemek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    new FrmPayment(this).Show();
                }
                return false;
            }
            return true;
        }

        private int CreateReservation(SqlConnection connection, SqlTransaction transaction, int houseId, DateTime startDate, DateTime endDate, double totalPrice)
        {
            string query = @"
                INSERT INTO tblReservation 
                (houseId, userId, checkInDate, checkOutDate, guestCount, totalPrice, reservationDate, status, isApproved, isCancelled)
                OUTPUT INSERTED.reservationId
                VALUES (@houseId, @userId, @checkIn, @checkOut, @guestCount, @totalPrice, @resDate, @status, @approved, @cancelled)";

            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@houseId", houseId);
                cmd.Parameters.AddWithValue("@userId", Session.UserId);
                cmd.Parameters.AddWithValue("@checkIn", startDate);
                cmd.Parameters.AddWithValue("@checkOut", endDate);
                cmd.Parameters.AddWithValue("@guestCount", 2); // Varsayılan misafir sayısı
                cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@resDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@status", "Pending");
                cmd.Parameters.AddWithValue("@approved", false);
                cmd.Parameters.AddWithValue("@cancelled", false);

                return (int)cmd.ExecuteScalar();
            }
        }

        private void CreatePayment(SqlConnection connection, SqlTransaction transaction, int reservationId, double totalPrice)
        {
            string query = @"
                INSERT INTO tblPayment 
                (paymentDate, price, paymentMethod, isPaid, reservationId)
                VALUES (@p1, @p2, @p3, @p4, @p5)";

            using (var cmd = new SqlCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@p1", DateTime.Now);
                cmd.Parameters.AddWithValue("@p2", totalPrice);
                cmd.Parameters.AddWithValue("@p3", "Kredi Kartı");
                cmd.Parameters.AddWithValue("@p4", true);
                cmd.Parameters.AddWithValue("@p5", reservationId);

                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateUserBalance(double totalPrice)
        {
            UserData.Money -= (decimal)totalPrice;
            UpdateBalanceLabel();
        }
    }

    public class HouseItem
    {
        public int Id { get; }
        public string Name { get; }

        public HouseItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => Name;
    }
}