using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RentTinyHouse
{
    public partial class FrmHostAdvertUpdate : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;";
        private int selectedHouseId = -1;
        private bool isLoadingData = false;

        public FrmHostAdvertUpdate()
        {
            InitializeComponent();
        }

        private void FrmHostAdvertUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCities();
                LoadAdverts();
                ConfigureDataGridView();
                cbCity.SelectedIndexChanged += cbCity_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                ShowError("Form yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void ConfigureDataGridView()
        {
            dgvAdverts.AutoGenerateColumns = false;
            dgvAdverts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdverts.MultiSelect = false;

            // DataGridView sütunlarını tanımla
            dgvAdverts.Columns.Clear();
            dgvAdverts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "houseId",
                DataPropertyName = "houseId",
                HeaderText = "ID",
                Visible = false
            });
            dgvAdverts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "title",
                DataPropertyName = "title",
                HeaderText = "Başlık",
                Width = 150
            });
            dgvAdverts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "cityName",
                DataPropertyName = "cityName",
                HeaderText = "Şehir",
                Width = 100
            });
            dgvAdverts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "townName",
                DataPropertyName = "townName",
                HeaderText = "İlçe",
                Width = 100
            });
            dgvAdverts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "pricePerNight",
                DataPropertyName = "pricePerNight",
                HeaderText = "Fiyat",
                Width = 80
            });
            dgvAdverts.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "isActive",
                DataPropertyName = "isActive",
                HeaderText = "Aktif",
                Width = 50
            });
        }

        private void LoadAdverts()
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(
                    @"SELECT h.houseId, h.title, h.description, h.cityId, h.townId, 
                             h.pricePerNight, h.maxGuests, h.isActive,
                             c.cityName, t.townName
                      FROM tblHouse h
                      INNER JOIN tblCity c ON h.cityId = c.cityId
                      INNER JOIN tblTown t ON h.townId = t.townId
                      WHERE h.hostId = @hostId
                      ORDER BY h.title", conn))
                {
                    cmd.Parameters.AddWithValue("@hostId", Session.UserId);

                    var adapter = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    dgvAdverts.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Güncellenecek ilan bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("İlanlar yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void LoadCities()
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand("SELECT cityId, cityName FROM tblCity ORDER BY cityName", conn))
                {
                    var adapter = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    cbCity.DisplayMember = "cityName";
                    cbCity.ValueMember = "cityId";
                    cbCity.DataSource = dt;
                    cbCity.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowError("Şehirler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void LoadTowns(int cityId)
        {
            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(
                    "SELECT townId, townName FROM tblTown WHERE cityId = @cityId ORDER BY townName", conn))
                {
                    cmd.Parameters.AddWithValue("@cityId", cityId);

                    var adapter = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    cbTown.DisplayMember = "townName";
                    cbTown.ValueMember = "townId";
                    cbTown.DataSource = dt;
                    cbTown.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowError("İlçeler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void dgvAdverts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                isLoadingData = true;

                var row = dgvAdverts.Rows[e.RowIndex];
                selectedHouseId = Convert.ToInt32(row.Cells["houseId"].Value);

                txtTitle.Text = row.Cells["title"].Value?.ToString() ?? "";
                txtDescription.Text = row.Cells["description"].Value?.ToString() ?? "";

                if (row.Cells["cityId"].Value != DBNull.Value)
                {
                    int cityId = Convert.ToInt32(row.Cells["cityId"].Value);
                    cbCity.SelectedValue = cityId;

                    if (row.Cells["townId"].Value != DBNull.Value)
                    {
                        int townId = Convert.ToInt32(row.Cells["townId"].Value);
                        cbTown.SelectedValue = townId;
                    }
                }

                nudPrice.Value = row.Cells["pricePerNight"].Value != DBNull.Value ?
                    Convert.ToDecimal(row.Cells["pricePerNight"].Value) : nudPrice.Minimum;

                nudGuests.Value = row.Cells["maxGuests"].Value != DBNull.Value ?
                    Convert.ToInt32(row.Cells["maxGuests"].Value) : nudGuests.Minimum;

                chkIsActive.Checked = row.Cells["isActive"].Value != DBNull.Value &&
                    Convert.ToBoolean(row.Cells["isActive"].Value);

                isLoadingData = false;
            }
            catch (Exception ex)
            {
                isLoadingData = false;
                ShowError("İlan bilgileri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            if (!ValidateSelection()) return;

            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd = CreateUpdateCommand(conn))
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("İlan başarıyla güncellendi.", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAdverts();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme yapılamadı. İlan bulunamadı veya değişiklik yapılmadı.",
                            "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 547)
            {
                ShowError("Geçersiz şehir veya ilçe bilgisi. Lütfen seçimlerinizi kontrol edin.");
            }
            catch (Exception ex)
            {
                ShowError("Güncelleme sırasında hata oluştu: " + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                ShowWarning("Lütfen ilan başlığı giriniz.", txtTitle);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                ShowWarning("Lütfen ilan açıklaması giriniz.", txtDescription);
                return false;
            }

            if (cbCity.SelectedValue == null || cbCity.SelectedIndex == -1)
            {
                ShowWarning("Lütfen bir şehir seçiniz.", cbCity);
                return false;
            }

            if (cbTown.SelectedValue == null || cbTown.SelectedIndex == -1)
            {
                ShowWarning("Lütfen bir ilçe seçiniz.", cbTown);
                return false;
            }

            if (nudPrice.Value <= 0)
            {
                ShowWarning("Lütfen geçerli bir fiyat giriniz.", nudPrice);
                return false;
            }

            if (nudGuests.Value <= 0)
            {
                ShowWarning("Lütfen geçerli bir misafir sayısı giriniz.", nudGuests);
                return false;
            }

            return true;
        }

        private bool ValidateSelection()
        {
            if (selectedHouseId == -1)
            {
                ShowWarning("Lütfen güncellenecek ilanı seçin.");
                return false;
            }
            return true;
        }

        private SqlCommand CreateUpdateCommand(SqlConnection conn)
        {
            var cmd = new SqlCommand(
                @"UPDATE tblHouse 
                SET title = @title,
                    description = @description,
                    cityId = @cityId,
                    townId = @townId,
                    pricePerNight = @price,
                    maxGuests = @guests,
                    isActive = @active
                WHERE houseId = @houseId AND hostId = @hostId", conn);

            cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
            cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("@cityId", Convert.ToInt32(cbCity.SelectedValue));
            cmd.Parameters.AddWithValue("@townId", Convert.ToInt32(cbTown.SelectedValue));
            cmd.Parameters.AddWithValue("@price", nudPrice.Value);
            cmd.Parameters.AddWithValue("@guests", (int)nudGuests.Value);
            cmd.Parameters.AddWithValue("@active", chkIsActive.Checked);
            cmd.Parameters.AddWithValue("@houseId", selectedHouseId);
            cmd.Parameters.AddWithValue("@hostId", Session.UserId);

            return cmd;
        }

        private void ResetForm()
        {
            selectedHouseId = -1;
            txtTitle.Clear();
            txtDescription.Clear();
            cbCity.SelectedIndex = -1;
            cbTown.DataSource = null;
            cbTown.Items.Clear();
            nudPrice.Value = nudPrice.Minimum;
            nudGuests.Value = nudGuests.Minimum;
            chkIsActive.Checked = true;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarning(string message, Control control = null)
        {
            MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control?.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmHost().Show();
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoadingData) return;

            if (cbCity.SelectedValue != null &&
                cbCity.SelectedValue != DBNull.Value &&
                int.TryParse(cbCity.SelectedValue.ToString(), out int cityId))
            {
                LoadTowns(cityId);
            }
            else
            {
                cbTown.DataSource = null;
                cbTown.Items.Clear();
            }
        }
    }
}