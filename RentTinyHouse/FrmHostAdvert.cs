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
    public partial class FrmHostAdvert : Form
    {
        public FrmHostAdvert()
        {
            InitializeComponent();
        }

        private void FrmHostAdvert_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
            {
                string query = "SELECT pricePerNight AS 'Fiyat (₺)', description AS 'Açıklama', isActive AS 'Aktif Mi?' FROM tblHouse WHERE hostId = @hostId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@hostId", Session.UserId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
        }

        private void btnAdvertAdd_Click(object sender, EventArgs e)
        {
            FrmHostAdvertAdd frmHostAdvertAdd = new FrmHostAdvertAdd();
            frmHostAdvertAdd.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHost frmHost = new FrmHost();
            frmHost.Show();
            this.Close();
        }

        private void btnAdvertUpdate_Click(object sender, EventArgs e)
        {
            FrmHostAdvertUpdate frmAdvertUpdate = new FrmHostAdvertUpdate();
            frmAdvertUpdate.Show();
            this.Close();
        }
    }
}
