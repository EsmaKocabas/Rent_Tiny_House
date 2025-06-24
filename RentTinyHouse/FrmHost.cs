using System;
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
    public partial class FrmHost : Form
    {
        public FrmHost()
        {
            InitializeComponent();
        }

        private void btnAdvert_Click(object sender, EventArgs e)
        {
            FrmHostAdvert hostAdvert = new FrmHostAdvert();
            hostAdvert.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            int selectedHouseId = 4;
            FrmHostReviews reviews = new FrmHostReviews(selectedHouseId);
            reviews.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FrmHostPayment frmHostPayment = new FrmHostPayment();
            frmHostPayment.Show();
            this.Hide();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            FrmHostReservation frmHostReservation = new FrmHostReservation();
            frmHostReservation.Show();
            this.Hide();
        }
    }
}
