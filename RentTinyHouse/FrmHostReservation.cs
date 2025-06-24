using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RentTinyHouse
{
    public partial class FrmHostReservation : Form
    {
        public FrmHostReservation()
        {
            InitializeComponent();
        }

        private void FrmHostReservation_Load(object sender, EventArgs e)
        {
            LoadReservations();

            if (dataGridView1.Columns["ApproveBtn"] == null)
            {
                DataGridViewButtonColumn approveBtn = new DataGridViewButtonColumn();
                approveBtn.Name = "ApproveBtn";
                approveBtn.HeaderText = "Onayla";
                approveBtn.Text = "Onayla";
                approveBtn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(approveBtn);
            }

            if (dataGridView1.Columns["RejectBtn"] == null)
            {
                DataGridViewButtonColumn rejectBtn = new DataGridViewButtonColumn();
                rejectBtn.Name = "RejectBtn";
                rejectBtn.HeaderText = "Reddet";
                rejectBtn.Text = "Reddet";
                rejectBtn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(rejectBtn);
            }

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void LoadReservations()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
            {
                string query = @"SELECT reservationId, houseId, userId, checkInDate, checkOutDate, guestCount, totalPrice, reservationDate, status, isApproved, isCancelled FROM tblReservation";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int reservationId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["reservationId"].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "ApproveBtn")
            {
                ApproveReservation(reservationId);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "RejectBtn")
            {
                string reason = Microsoft.VisualBasic.Interaction.InputBox("İptal sebebini giriniz:", "İptal Sebebi", "Ev uygun değil");
                if (!string.IsNullOrWhiteSpace(reason))
                {
                    RejectReservation(reservationId, reason);
                }
            }
        }

        private void ApproveReservation(int reservationId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
            {
                string query = @"
                    UPDATE tblReservation
                    SET isApproved = 1,
                        isCancelled = 0,
                        status = 'Completed' -- CHECK constraint'a uygun bir değer (örneğin: 'Completed')
                    WHERE reservationId = @reservationId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@reservationId", reservationId);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Rezervasyon onaylandı.");
                LoadReservations();
            }
        }

        private void RejectReservation(int reservationId, string reason)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
            {
                string query = @"
                    UPDATE tblReservation
                    SET isCancelled = 1,
                        isApproved = 0,
                        status = 'Cancelled', -- CHECK constraint'a uygun bir değer (eğer 'Cancelled' izin verilmiyorsa 'Rejected' gibi başka bir değer deneyin)
                        cancelledAt = GETDATE(),
                        cancelReason = @reason,
                        cancelledBy = @hostId
                    WHERE reservationId = @reservationId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@reservationId", reservationId);
                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.Parameters.AddWithValue("@hostId", Session.UserId);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Rezervasyon reddedildi.");
                LoadReservations();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHost host = new FrmHost();
            host.Show();
            this.Hide();
        }
    }
}