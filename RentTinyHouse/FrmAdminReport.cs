using Microsoft.Data.SqlClient;
using System.Data;

namespace RentTinyHouse
{
    public partial class FrmAdminReport : Form
    {
        public FrmAdminReport()
        {
            InitializeComponent();
        }

        private void FrmAdminReport_Load(object sender, EventArgs e)
        {
            // Bağlantı dizesi
            string connectionString = "Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // İstatistik verilerini al
            int activeUsers = GetCount(connection, "SELECT COUNT(*) FROM tblUser WHERE isActive = 1");
            int totalReservations = GetCount(connection, "SELECT COUNT(*) FROM tblReservation");
            int totalPayments = GetCount(connection, "SELECT COUNT(*) FROM tblPayment");
            int totalComments = GetCount(connection, "SELECT COUNT(*) FROM tblReview");

            // DataGrid'e veri ekle
            DataTable dt = new DataTable();
            dt.Columns.Add("İstatistik");
            dt.Columns.Add("Sayı");

            dt.Rows.Add("Aktif Kullanıcı Sayısı", activeUsers);
            dt.Rows.Add("Toplam Rezervasyon Sayısı", totalReservations);
            dt.Rows.Add("Toplam Ödeme Sayısı", totalPayments);
            dt.Rows.Add("Toplam Yorum Sayısı", totalComments);

            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            connection.Close();
        }

        // Sayı döndüren sorgular için yardımcı metot
        private int GetCount(SqlConnection conn, string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                return (int)cmd.ExecuteScalar();
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
