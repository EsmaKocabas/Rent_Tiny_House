using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentTinyHouse
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True");

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            // Kullanıcı tiplerini ComboBox'a yükle
            SqlDataAdapter da = new SqlDataAdapter("SELECT roleId, roleName FROM tblRoles", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUserType.DataSource = dt;
            cmbUserType.DisplayMember = "roleName";
            cmbUserType.ValueMember = "roleId";

            txtPassword1.UseSystemPasswordChar = true;
            txtPassword2.UseSystemPasswordChar = true;
            cbPassword1.Checked = false;
            cbPassword2.Checked = false;
            if (cmbUserType.Items.Count > 0)
            {
                cmbUserType.SelectedIndex = 0;
            }
        }

        void usernameControl()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                throw new Exception("İsim Bölümü Boş Bırakılamaz");
            }
        }

        void passwordControl()
        {
            if (string.IsNullOrWhiteSpace(txtPassword1.Text))
            {
                throw new Exception("Şifre Bölümü Boş Bırakılamaz");
            }
        }

        bool passwordMatch()
        {
            if (txtPassword1.Text != txtPassword2.Text)
            {
                throw new Exception("Şifreler Eşleşmedi");
            }
            return true;
        }

        void mailControl()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                throw new Exception("Email alanı boş bırakılamaz.");
            }

            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if (!reg.IsMatch(txtEmail.Text))
            {
                throw new Exception("E-posta adresi geçerli değil.");
            }
        }

        void clean()
        {
            txtEmail.Clear();
            txtName.Clear();
            txtSurname.Clear();
            mskNum.Clear();
            txtPassword1.Clear();
            txtPassword2.Clear();
            pbUserImage.Image = null;
            cmbUserType.SelectedIndex = -1;
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Giriş kontrolleri
                mailControl();
                passwordControl();
                usernameControl();
                passwordMatch();
                Image image = pbUserImage.Image ?? Properties.Resources.login;


                if (string.IsNullOrWhiteSpace(txtSurname.Text) ||
     string.IsNullOrWhiteSpace(mskNum.Text) ||
     image == null ||
     cmbUserType.SelectedIndex == -1)
                {
                    MessageBox.Show("Tüm alanları eksiksiz doldurun.");
                    return;
                }

                connection.Open();


                SqlCommand command = new SqlCommand("INSERT INTO [tblUser] (isActive, firstName, lastName, email, passwordHash, phoneNumber, roleId, profileImage) " +
                                                    "VALUES (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8)", connection);
                command.Parameters.AddWithValue("@P1", 1);
                command.Parameters.AddWithValue("@P2", txtName.Text.Trim());
                command.Parameters.AddWithValue("@P3", txtSurname.Text.Trim());
                command.Parameters.AddWithValue("@P4", txtEmail.Text.Trim());
                command.Parameters.AddWithValue("@P5", txtPassword1.Text.Trim());
                command.Parameters.AddWithValue("@P6", mskNum.Text.Trim());
                command.Parameters.AddWithValue("@P7", cmbUserType.SelectedItem);

                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    command.Parameters.AddWithValue("@P8", ms.ToArray());
                }

                command.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla eklendi.");
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cbPassword1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword1.UseSystemPasswordChar = !cbPassword1.Checked;
        }

        private void cbPassword2_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword2.UseSystemPasswordChar = !cbPassword2.Checked;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Resim Seçin",
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbUserImage.Image = new Bitmap(openFileDialog.FileName);
                pbUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMain mainPage = new FrmMain();
            this.Close();
            mainPage.Show();
        }
    }
}
