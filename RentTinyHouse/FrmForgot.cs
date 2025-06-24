using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RentTinyHouse
{
    public partial class FrmForgot : Form
    {
        public FrmForgot()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True");

        private void FrmForgot_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword2.UseSystemPasswordChar = true;
            cbPassword1.Checked = false;
            cbPassword2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordControl() && mailControl())
            {
                try
                {
                    connection.Open();

                    // Kullanıcı mevcut mu kontrol et
                    SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM tblUser WHERE email = @Email", connection);
                    checkUser.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    int userExists = (int)checkUser.ExecuteScalar();

                    if (userExists == 0)
                    {
                        MessageBox.Show("Bu e-posta adresine ait kullanıcı bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Şifreyi güncelle
                    SqlCommand updatePassword = new SqlCommand("UPDATE tblUser SET passwordHash = @Password WHERE email = @Email", connection);
                    updatePassword.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    updatePassword.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                    int rowsAffected = updatePassword.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Şifre başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmLogin login = new FrmLogin();
                        this.Hide();
                        login.Show();
                    }
                    else
                    {
                        MessageBox.Show("Şifre güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private bool mailControl()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("* E-posta alanı boş bırakılamaz.");
                return false;
            }

            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(txtEmail.Text.Trim()))
            {
                MessageBox.Show("* E-Posta adresi geçerli değil.");
                return false;
            }

            return true;
        }

        private bool passwordControl()
        {
            string password = txtPassword.Text.Trim();
            string password2 = txtPassword2.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Şifre bölümü boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(password2))
            {
                MessageBox.Show("Şifre onaylama bölümü boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (password != password2)
            {
                MessageBox.Show("Şifreler eşleşmiyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void cbPassword1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword2.UseSystemPasswordChar = !cbPassword1.Checked;
        }

        private void cbPassword2_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbPassword2.Checked;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Close();
            login.Show();
        }
    }
}
