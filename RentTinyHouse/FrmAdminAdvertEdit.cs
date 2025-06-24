using Microsoft.VisualBasic;
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
    public partial class FrmAdminAdvertEdit : Form
    {
        private readonly int _houseId;
        private readonly int _hostId;

        public FrmAdminAdvertEdit(int houseId, int hostId, string firstName, string lastName,
                           string price, string date, string location)
        {
            InitializeComponent();
            _houseId = houseId;
            _hostId = hostId;

            txtName.Text = firstName;
            txtSurname.Text = lastName;
            txtPrice.Text = price;
            dtpDate.Value = DateTime.TryParse(date, out var parsedDate) ? parsedDate : DateTime.Now;
            txtLocation.Text = location;
        }
        private void FrmAdminAdvertEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updateHouseSql = @"UPDATE tblHouse SET 
                                       createdAt = @date
                                       WHERE houseId = @houseId;

                                       UPDATE HouseDetail SET 
                                       price = @price, 
                                       Location = @location
                                       WHERE houseId = @houseId";

                    string updateUserSql = @"UPDATE tblUser SET
                                      firstName = @firstName,
                                      lastName = @lastName
                                      WHERE userId = @hostId";

                    SqlCommand cmdHouse = new SqlCommand(updateHouseSql, connection, transaction);
                    cmdHouse.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    cmdHouse.Parameters.AddWithValue("@location", txtLocation.Text);
                    cmdHouse.Parameters.AddWithValue("@houseId", _houseId);
                    cmdHouse.Parameters.AddWithValue("@date", dtpDate.Value); // date parametresi unutulmasın
                    cmdHouse.ExecuteNonQuery();

                    SqlCommand cmdUser = new SqlCommand(updateUserSql, connection, transaction);
                    cmdUser.Parameters.AddWithValue("@firstName", txtName.Text);
                    cmdUser.Parameters.AddWithValue("@lastName", txtSurname.Text);
                    cmdUser.Parameters.AddWithValue("@hostId", _hostId);
                    cmdUser.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Güncelleme başarılı.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            FrmAdminAdvert adminAdvert= new FrmAdminAdvert();
            adminAdvert.Show();
            this.Hide();
        }
    }
}
