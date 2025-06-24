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
using System.Globalization;
using System.Text.RegularExpressions;

namespace RentTinyHouse
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        void passwordControl()
        {
            string sifre = txtPassword.Text.Trim(); // Boşlukları temizle

            if (string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Şifre Bölümü Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void mailControl()
        {
            if (!string.IsNullOrWhiteSpace(txtMail.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

                // Girilen e-posta adresi, Regex ifadesiyle eşleşmiyorsa
                if (!reg.IsMatch(txtMail.Text))
                {
                    MessageBox.Show("* E-Posta adresi geçerli değil.");
                    return; // Geçersiz e-posta adresi durumunda işlemi sonlandır
                }




                else // Eğer e-posta alanı boşsa
                {
                    MessageBox.Show("* Email alanı boş bırakılamaz.");
                }
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            mailControl();
            passwordControl();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister register = new FrmRegister();
            FrmLogin login = new FrmLogin();
            login.Close();
            register.Show();
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgot forgot = new FrmForgot();
            FrmLogin login = new FrmLogin();
            login.Close();
            forgot.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain mainPage = new FrmMain();
            this.Hide();
            mainPage.Show();
        }
        public int getUserRole()
        {
            int id = 3;
            return id;//kullanıcının roleId'sine göre dönecek
            //1:User
            //2:Ev Sahibi
            //3:Admin
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtMail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("E-posta ve şifre boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // E-posta kontrolü
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(username))
            {
                MessageBox.Show("Geçersiz e-posta adresi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;"))
            {
                conn.Open();
                string query = "SELECT userId, roleId FROM tblUser WHERE email = @email AND passwordHash = @passwordHash";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", username);
                    cmd.Parameters.AddWithValue("@passwordHash", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        int roleId = reader.GetInt32(1);

                        // (Opsiyonel) Giriş yapan kullanıcı bilgilerini hafızada tutmak için static class kullanabilirsin
                        Session.UserId = userId;
                        Session.RoleId = roleId;

                        this.Hide();

                        switch (roleId)
                        {
                            case 1:
                                FrmMain userForm = new FrmMain();
                                userForm.Show();
                                break;
                            case 2:
                                FrmHost hostForm = new FrmHost();
                                hostForm.Show();
                                break;
                            case 3:
                                FrmAdmin adminForm = new FrmAdmin();
                                adminForm.Show();
                                break;
                            default:
                                MessageBox.Show("Tanımsız rol!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                //Şifre Görüntüleme
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgot forgot = new FrmForgot();
            forgot.Show();
            this.Hide();
        }
    }
}
     
    



       
 
