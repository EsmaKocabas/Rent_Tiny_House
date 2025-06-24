using Microsoft.VisualBasic.ApplicationServices;

namespace RentTinyHouse
{
    public partial class FrmMain : Form
    {
        int houseId = 4;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            FrmReservations res = new FrmReservations();
            this.Hide();
            res.Show();
        }
        private void btnKirala1_Click(object sender, EventArgs e)
        {
            FrmRent rent1 = new FrmRent();
            this.Hide();
            rent1.Show();
        }
        private void btnKirala2_Click(object sender, EventArgs e)
        {
            FrmRent rent2 = new FrmRent();
            this.Hide();
            rent2.Show();
        }
        private void btnKirala3_Click(object sender, EventArgs e)
        {
            FrmRent rent3 = new FrmRent();
            this.Hide();
            rent3.Show();
        }
        private void btnReview1_Click(object sender, EventArgs e)
        {

            FrmReview review1 = new FrmReview(houseId);
            this.Hide();
            review1.Show();

        }
        private void btnReview2_Click(object sender, EventArgs e)
        {

            FrmReview review2 = new FrmReview(houseId);
            this.Hide();
            review2.Show();

        }
        private void btnReview3_Click(object sender, EventArgs e)
        {

            FrmReview review3 = new FrmReview(houseId);
            this.Hide();
            review3.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            FrmLogin login = new FrmLogin();
            this.Hide();
            login.Show();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            this.Hide();
            register.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPopuler_Click(object sender, EventArgs e)
        {
            FrmPopulerHouse populer = new FrmPopulerHouse();
            this.Hide();
            populer.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void housePrice4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.Show();
        }
    }
}
