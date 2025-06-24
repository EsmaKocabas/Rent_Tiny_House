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
using System.Windows.Forms.DataVisualization.Charting;

namespace RentTinyHouse
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        private void InitializePieChart()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.ChartAreas.Clear();
            chart1.Legends.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);
            Series series = new Series("İlanlar");
            series.ChartType = SeriesChartType.Pie;

            // Veritabanından bölgeye göre ilan sayısını al
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                string sql = "SELECT c.cityName, COUNT(*) AS IlanSayisi FROM tblHouse h\r\ninner join tblCity c on c.cityId=h.cityId\r\nGROUP BY c.cityName";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string location = reader["cityName"].ToString();
                    int count = Convert.ToInt32(reader["IlanSayisi"]);
                    series.Points.AddXY(location, count);
                }

                reader.Close();
            }

            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";
            series.Label = "#PERCENT{P1}"; // % olarak göster
            series.LegendText = "#VALX (#VALY)"; // Açıklamada: İstanbul (10) gibi
            series.Font = new Font("Arial", 10, FontStyle.Regular);
            series.BorderColor = Color.White;
            series.BorderWidth = 2;

            chartArea.Area3DStyle.Enable3D = true;
            chartArea.Area3DStyle.Inclination = 45;

            chart1.Series.Add(series);

            Legend legend = new Legend();
            legend.Title = "Konumlar";
            legend.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            chart1.Legends.Add(legend);
        }


        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            InitializePieChart();
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;");
            connection.Open();

            string query = "SELECT COUNT(*) FROM tblUser WHERE isActive = 1";
            SqlCommand cmd = new SqlCommand(query, connection);
            int activeUserCount = (int)cmd.ExecuteScalar(); // sorgunun sonucunu al

            lblActiveUsers.Text = activeUserCount.ToString(); // sayıyı label'a yaz

            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminUsers adminUsers = new FrmAdminUsers();
            adminUsers.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAdminReservations adminReservations = new FrmAdminReservations();
            adminReservations.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminAdvert adminAdvert = new FrmAdminAdvert();
            adminAdvert.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAdminPayment adminPayment = new FrmAdminPayment();
            adminPayment.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmAdminReport adminReport = new FrmAdminReport();
            adminReport.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMain main = new FrmMain();
            main.Show();
            this.Hide();
        }
    }
}
