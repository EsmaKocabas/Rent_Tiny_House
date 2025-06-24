using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RentTinyHouse
{
    public partial class FrmAdminReservations : Form
    {
        public FrmAdminReservations()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmAdminReservations_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;");
            connection.Open();
            string query = @"EXEC sp_GetReservationReport";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            if (!dataGridView1.Columns.Contains("btnCancel"))
            {
                DataGridViewButtonColumn cancelColumn = new DataGridViewButtonColumn();
                cancelColumn.Name = "btnCancel";
                cancelColumn.HeaderText = "İşlem";
                cancelColumn.Text = "İptal Et";
                cancelColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(cancelColumn);
            }

            dataGridView1.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == dataGridView1.Columns["btnCancel"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int reservationId = Convert.ToInt32(row.Cells["reservationId"].Value);
                    string customerName = row.Cells["Ad"].Value + " " + row.Cells["Soyad"].Value;

                    DialogResult result = MessageBox.Show(
                        $"{customerName} müşterisinin rezervasyonunu iptal etmek istediğinize emin misiniz?",
                        "Onay",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection conn = new SqlConnection(connection.ConnectionString))
                            {
                                string updateQuery = @"UPDATE tblReservation 
                                         SET isCancelled = 1 
                                         WHERE reservationId = @reservationId";

                                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                                cmd.Parameters.AddWithValue("@reservationId", reservationId);

                                conn.Open();
                                int affectedRows = cmd.ExecuteNonQuery();

                                if (affectedRows > 0)
                                {

                                    RefreshDataGrid();
                                    MessageBox.Show("Rezervasyon iptal edildi ve listeden kaldırıldı.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                }
            };
        }
        private void RefreshDataGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    string query = @"SELECT 
                u.userId,
                u.firstName AS 'Ad',
                u.lastName AS 'Soyad',
                r.reservationId,
                r.checkInDate AS 'Giriş Tarihi',
                r.checkOutDate AS 'Çıkış Tarihi',
                DATEDIFF(day, r.checkInDate, r.checkOutDate) AS 'Konaklama Süresi (Gün)',
                p.price AS 'Ödeme Tutarı',
                CASE 
                    WHEN p.isPaid = 1 THEN 'Ödendi'
                    ELSE 'Ödenmedi'
                END AS 'Ödeme Durumu',
                p.paymentDate AS 'Ödeme Tarihi'
            FROM 
                tblReservation r
            INNER JOIN 
                tblUser u ON u.userId = r.userId
            INNER JOIN 
                tblPayment p ON p.reservationId = r.reservationId
            WHERE
                r.isCancelled = 0 -- Sadece aktif rezervasyonlar
            ORDER BY
                r.checkInDate DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yenilenirken hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Hide();
        }
    }
}
