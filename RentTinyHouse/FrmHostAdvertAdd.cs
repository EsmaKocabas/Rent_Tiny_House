using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RentTinyHouse
{
    public partial class FrmHostAdvertAdd : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;";

        public FrmHostAdvertAdd()
        {
            InitializeComponent();
        }

        private void FrmHostAdvertAdd_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCities();
                cbCity.SelectedIndexChanged += cbCity_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCities()
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT cityId, cityName FROM tblCity ORDER BY cityName", conn))
            {
                try
                {
                    conn.Open();
                    var dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    cbCity.DisplayMember = "cityName";
                    cbCity.ValueMember = "cityId";
                    cbCity.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Şehirler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCity.SelectedValue != null && int.TryParse(cbCity.SelectedValue.ToString(), out int cityId))
            {
                LoadTowns(cityId);
            }
            else
            {
                cbTown.DataSource = null;
                cbTown.Items.Clear();
            }
        }

        private void LoadTowns(int cityId)
        {
            using (var conn = new SqlConnection(ConnectionString))
            using (var cmd = new SqlCommand("SELECT townId, townName FROM tblTown WHERE cityId = @cityId ORDER BY townName", conn))
            {
                cmd.Parameters.AddWithValue("@cityId", cityId);

                try
                {
                    conn.Open();
                    var dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    cbTown.DisplayMember = "townName";
                    cbTown.ValueMember = "townId";
                    cbTown.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"İlçeler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    if (!ValidateSelectionsInDatabase(conn))
                        return;

                    InsertHouseRecord(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İlan eklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Lütfen ilan başlığı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Lütfen ilan açıklaması giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return false;
            }

            if (cbCity.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir şehir seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCity.Focus();
                return false;
            }

            if (cbTown.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir ilçe seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTown.Focus();
                return false;
            }

            if (nudPrice.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPrice.Focus();
                return false;
            }

            if (nudGuests.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir misafir sayısı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudGuests.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateSelectionsInDatabase(SqlConnection conn)
        {
            try
            {
                int cityId = Convert.ToInt32(cbCity.SelectedValue);
                int townId = Convert.ToInt32(cbTown.SelectedValue);

                using (var cmd = new SqlCommand("SELECT COUNT(1) FROM tblCity WHERE cityId = @cityId", conn))
                {
                    cmd.Parameters.AddWithValue("@cityId", cityId);
                    if ((int)cmd.ExecuteScalar() == 0)
                    {
                        MessageBox.Show("Seçilen şehir veritabanında bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                using (var cmd = new SqlCommand("SELECT COUNT(1) FROM tblTown WHERE townId = @townId AND cityId = @cityId", conn))
                {
                    cmd.Parameters.AddWithValue("@townId", townId);
                    cmd.Parameters.AddWithValue("@cityId", cityId);
                    if ((int)cmd.ExecuteScalar() == 0)
                    {
                        MessageBox.Show("Seçilen ilçe veritabanında bulunamadı veya şehirle eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Doğrulama sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void InsertHouseRecord(SqlConnection conn)
        {
            using (var cmd = new SqlCommand(
                @"INSERT INTO tblHouse 
                (hostId, title, description, cityId, townId, pricePerNight, maxGuests, createdAt, isActive)
                VALUES 
                (@hostId, @title, @description, @cityId, @townId, @pricePerNight, @maxGuests, @createdAt, @isActive)", conn))
            {
                cmd.Parameters.AddWithValue("@hostId", Session.UserId);
                cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                cmd.Parameters.AddWithValue("@cityId", Convert.ToInt32(cbCity.SelectedValue));
                cmd.Parameters.AddWithValue("@townId", Convert.ToInt32(cbTown.SelectedValue));
                cmd.Parameters.AddWithValue("@pricePerNight", nudPrice.Value);
                cmd.Parameters.AddWithValue("@maxGuests", (int)nudGuests.Value);
                cmd.Parameters.AddWithValue("@createdAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@isActive", chkIsActive.Checked);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("İlan başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("İlan eklenirken beklenmeyen bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetForm()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            cbCity.SelectedIndex = -1;
            cbTown.SelectedIndex = -1;
            nudPrice.Value = nudPrice.Minimum;
            nudGuests.Value = nudGuests.Minimum;
            chkIsActive.Checked = true;
            txtTitle.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmHost().Show();
        }
    }
}