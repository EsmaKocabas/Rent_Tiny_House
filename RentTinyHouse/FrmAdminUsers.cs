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
    public partial class FrmAdminUsers : Form
    {
        public FrmAdminUsers()
        {
            InitializeComponent();
        }

        private void FrmAdminUsers_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;");
            connection.Open();
            string query = "select userId,firstName,lastName,email from tblUser";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtgUser.DataSource = dataTable;
            if (!dtgUser.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "btnEdit";
                btnColumn.HeaderText = "İşlem";
                btnColumn.Text = "Düzenle";
                btnColumn.UseColumnTextForButtonValue = true;
                dtgUser.Columns.Add(btnColumn);
            }

            dtgUser.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == dtgUser.Columns["btnEdit"].Index && e.RowIndex >= 0)
                {
                    DataGridViewRow row = dtgUser.Rows[e.RowIndex];
                    int userId = Convert.ToInt32(row.Cells["userId"].Value);
                    string firstName = row.Cells["firstName"].Value.ToString();
                    string lastName = row.Cells["lastName"].Value.ToString();
                    string email = row.Cells["email"].Value.ToString();

                    FrmAdminEdit editForm = new FrmAdminEdit(userId, firstName, lastName, email);
                    editForm.ShowDialog();
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
                {
                    connection.Open();
                    string filterText = txtFilter.Text.Trim();
                    string sql = "SELECT userId, firstName, lastName, email FROM tblUser";

                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DataView dv = dataTable.DefaultView;

                    if (!string.IsNullOrEmpty(filterText))
                    {
                        dv.RowFilter = $"firstName LIKE '%{filterText.Replace("'", "''")}%' OR " +
                                      $"lastName LIKE '%{filterText.Replace("'", "''")}%' OR " +
                                      $"email LIKE '%{filterText.Replace("'", "''")}%'";
                    }
                    else
                    {
                        dv.RowFilter = string.Empty;
                    }

                    dtgUser.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Hide();
        }
    }
}
