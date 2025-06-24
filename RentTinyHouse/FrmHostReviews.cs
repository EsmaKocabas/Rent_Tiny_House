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
    public partial class FrmHostReviews : Form
    {
        private int _houseId;
        public FrmHostReviews(int houseId)
        {
            InitializeComponent();
            _houseId = houseId;
        }

        private void FrmHostReviews_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
            {
                string query = @"
    SELECT 
        (u.firstName + ' ' + u.lastName) AS Kullanici,
        r.rating AS Puan,
        r.comment AS Yorum,
        r.reviewDate AS Tarih
    FROM tblReview r
    JOIN tblUser u ON r.userId = u.userId
    WHERE r.houseId = @houseId
    ORDER BY r.reviewDate DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@houseId", _houseId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHost hostForm = new FrmHost();
            hostForm.Show();
            this.Hide();
        }
    }
}
