using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace RentTinyHouse
{
    public partial class FrmReservations : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;";

        public class Reservation
        {
            public int Id { get; set; }
            public int HouseId { get; set; }
            public int UserId { get; set; }
            public DateTime CheckInDate { get; set; }
            public DateTime CheckOutDate { get; set; }
            public int GuestCount { get; set; }
            public decimal TotalPrice { get; set; }
            public DateTime ReservationDate { get; set; }
            public string Status { get; set; }
            public bool IsApproved { get; set; }
            public bool IsCancelled { get; set; }
            public DateTime? CancelledAt { get; set; }
            public string CancelReason { get; set; }
            public int? CancelledBy { get; set; }
        }

        private List<Reservation> allReservations = new List<Reservation>();

        public FrmReservations()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain mainPage = new FrmMain();
            this.Hide();
            mainPage.Show();
        }

        private void FrmReservations_Load(object sender, EventArgs e)
        {
            lblPrice.Visible = false;
            lblStatus.Visible = false;
            LoadReservationsFromDatabase();
            DisplayReservations();
        }

        private void LoadReservationsFromDatabase()
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    string query = @"SELECT reservationId, houseId, userId, checkInDate, checkOutDate, 
                                   guestCount, totalPrice, reservationDate, status, isApproved, 
                                   isCancelled, cancelledAt, cancelReason, cancelledBy 
                                   FROM tblReservation";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var reservation = new Reservation
                                {
                                    Id = reader.GetInt32(0),
                                    HouseId = reader.GetInt32(1),
                                    UserId = reader.GetInt32(2),
                                    CheckInDate = reader.GetDateTime(3),
                                    CheckOutDate = reader.GetDateTime(4),
                                    GuestCount = reader.GetInt32(5),
                                    TotalPrice = reader.GetDecimal(6),
                                    ReservationDate = reader.GetDateTime(7),
                                    Status = reader.GetString(8),
                                    IsApproved = reader.GetBoolean(9),
                                    IsCancelled = reader.GetBoolean(10),
                                    CancelledAt = reader.IsDBNull(11) ? (DateTime?)null : reader.GetDateTime(11),
                                    CancelReason = reader.IsDBNull(12) ? null : reader.GetString(12),
                                    CancelledBy = reader.IsDBNull(13) ? (int?)null : reader.GetInt32(13)
                                };
                                allReservations.Add(reservation);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyonlar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayReservations()
        {
            var today = DateTime.Today;

            var active = allReservations
                .Where(r => r.CheckOutDate >= today && !r.IsCancelled)
                .ToList();

            var past = allReservations
                .Where(r => r.CheckOutDate < today || r.IsCancelled)
                .ToList();

            // Configure active reservations grid
            dgvActiveReservations.DataSource = null;
            dgvActiveReservations.DataSource = active;
            ConfigureDataGridView(dgvActiveReservations);

            // Configure past reservations grid
            dgvPastReservations.DataSource = null;
            dgvPastReservations.DataSource = past;
            ConfigureDataGridView(dgvPastReservations);
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            // Add columns with appropriate headers and data properties
            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Rezervasyon ID",
                DataPropertyName = "Id"
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Ev ID",
                DataPropertyName = "HouseId"
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Giriş Tarihi",
                DataPropertyName = "CheckInDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Çıkış Tarihi",
                DataPropertyName = "CheckOutDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Toplam Fiyat",
                DataPropertyName = "TotalPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Durum",
                DataPropertyName = "Status"
            });

            dgv.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "İptal Edildi",
                DataPropertyName = "IsCancelled"
            });
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (dgvActiveReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iptal etmek için bir rezervasyon seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = (int)dgvActiveReservations.SelectedRows[0].Cells["Id"].Value;

            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE tblReservation 
                                   SET isCancelled = 1, 
                                       cancelledAt = @cancelledAt, 
                                       cancelledBy = @userId, 
                                       status = 'Cancelled'
                                   WHERE reservationId = @reservationId";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cancelledAt", DateTime.Now);
                        cmd.Parameters.AddWithValue("@userId", Session.UserId);
                        cmd.Parameters.AddWithValue("@reservationId", selectedId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Rezervasyon başarıyla iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadReservationsFromDatabase();
                            DisplayReservations();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İptal işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvActiveReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks if needed
        }
    }
}