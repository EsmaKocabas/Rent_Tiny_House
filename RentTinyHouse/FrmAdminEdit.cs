using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentTinyHouse
{
    public partial class FrmAdminEdit : Form
    {
        private readonly int _userId;
        public FrmAdminEdit(int userId, string firstName, string lastName, string email)
        {
            InitializeComponent();
            _userId = userId;
            txtName.Text = firstName;
            txtSurname.Text = lastName;
            txtEmail.Text = email;
        }

        private void FrmAdminEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;");
            string query = "UPDATE tblUser SET firstName=@firstName, lastName=@lastName, email=@email WHERE userId=@userId";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@firstName", txtName.Text);
            cmd.Parameters.AddWithValue("@lastName", txtSurname.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@userId", _userId);

            connection.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Kullanıcı bilgileri güncellendi!");
            this.Close();

            FrmAdminUsers adminUsers = new FrmAdminUsers();
            adminUsers.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminUsers adminUsers = new FrmAdminUsers();
            adminUsers.Show();
            this.Hide();
        }
    }
}
