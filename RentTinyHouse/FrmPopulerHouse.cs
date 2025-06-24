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
    public partial class FrmPopulerHouse : Form
    {
        public FrmPopulerHouse()
        {
            InitializeComponent();
        }
        SqlConnection connection=new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;");
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain mainPage = new FrmMain();
            this.Close();
            mainPage.Show();
        }

        private void FrmPopulerHouse_Load(object sender, EventArgs e)
        {
            string query = "select (u.firstName+' '+u.lastName) As[Ev Sahibi],h.title as[Başlık],h.description as[Açıklama],c.cityName as[İl],t.townName as[İlçe],h.pricePerNight as[Günlük Fiyat]\r\nfrom tblHouse h \r\ninner join tblCity c on c.cityId=h.cityId\r\ninner join tblTown t on t.townId=h.townId\r\ninner join tblUser u on u.userId=h.hostId";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt; // Veriler tabloya atanıyor
            }
        }
    }
}
