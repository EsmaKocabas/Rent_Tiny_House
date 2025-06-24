using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace RentTinyHouse
{
    public partial class FrmReview : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-DUEUI74;Initial Catalog=RentTinyHouse;Integrated Security=True;TrustServerCertificate=True;";
        private int _houseId; // Store the house ID being reviewed

        public FrmReview(int houseId)
        {
            InitializeComponent();
            _houseId = houseId;
        }

        private void FrmReview_Load(object sender, EventArgs e)
        {
            lblScore.Visible = false;
        }

        private void btnScore_Click_1(object sender, EventArgs e)
        {
            int score = trackScore.Value;
            MessageBox.Show("Puanınız: " + score.ToString(), "Puanlama", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trackScore_Scroll(object sender, EventArgs e)
        {
            lblScore.Text = "Seçilen puan: " + trackScore.Value.ToString();
            lblScore.Visible = true;
        }

        private void btnReview_Click_1(object sender, EventArgs e)
        {
            string reviewText = txtReview.Text.Trim();
            int rating = trackScore.Value;

            if (string.IsNullOrWhiteSpace(reviewText))
            {
                MessageBox.Show("Lütfen bir yorum girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Lütfen 1-5 arasında puan verin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string query = @"INSERT INTO tblReview 
                                   (houseId, userId, rating, comment, reviewDate)
                                   VALUES (@houseId, @userId, @rating, @comment, @reviewDate)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@houseId", _houseId);
                        cmd.Parameters.AddWithValue("@userId", Session.UserId); // Assuming you have user session
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Parameters.AddWithValue("@comment", reviewText);
                        cmd.Parameters.AddWithValue("@reviewDate", DateTime.Now);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Yorumunuz başarıyla gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yorum gönderilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtReview.Clear();
            trackScore.Value = 1;
            lblScore.Text = "Seçilen puan: 1";
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FrmMain mainPage = new FrmMain();
            this.Close();
            mainPage.Show();
        }
    }
}