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
    public partial class FrmAdminPayment : Form
    {
        public FrmAdminPayment()
        {
            InitializeComponent();
        }

        private void FrmAdminPayment_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;");
            connection.Open();
            string query = "select paymentId,paymentDate, paymentMethod,price,isPaid from tblPayment";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdminPayment = new FrmAdmin();
            frmAdminPayment.Show();
            this.Hide();
        }
    }
}
