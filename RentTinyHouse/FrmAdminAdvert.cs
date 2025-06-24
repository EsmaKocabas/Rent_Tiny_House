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
    public partial class FrmAdminAdvert : Form
    {
        public FrmAdminAdvert()
        {
            InitializeComponent();
        }

        private void FrmAdminAdvert_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;");
            connection.Open();
            string query = "EXEC sp_GetHouseReport";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            if (!dataGridView1.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "btnEdit";
                btnColumn.HeaderText = "İşlem";
                btnColumn.Text = "Düzenle";
                btnColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnColumn);
            }

            dataGridView1.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == dataGridView1.Columns["btnEdit"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    string ownerName = row.Cells["Ev Sahibi"].Value?.ToString();
                    string price = row.Cells["Ücret"].Value?.ToString();
                    string date = row.Cells["Tarih"].Value?.ToString();
                    string location = row.Cells["Konum"].Value?.ToString();

                    string[] nameParts = ownerName?.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstName = nameParts?.Length > 0 ? nameParts[0] : "";
                    string lastName = nameParts?.Length > 1 ? nameParts[1] : "";

                    int houseId = Convert.ToInt32(row.Cells["houseId"].Value);
                    int hostId = Convert.ToInt32(row.Cells["hostId"].Value);
                    FrmAdminAdvertEdit editForm = new FrmAdminAdvertEdit(
                        houseId: houseId,
                        hostId: hostId,
                        firstName: firstName,
                        lastName: lastName,
                        price: price,
                        date: date,
                        location: location);

                    editForm.ShowDialog();
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Hide();
        }
    }
}
