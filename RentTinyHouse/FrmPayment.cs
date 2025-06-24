using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace RentTinyHouse
{
    public partial class FrmPayment : Form
    {
        private Form previousForm; // Bu formdan önceki formu tutar
        private FrmRent frmRent;

        public FrmPayment(FrmRent frmRent)
        {
            InitializeComponent();
            this.frmRent = frmRent;
        }
        public FrmPayment(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm; // Önceki formu alır
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmRent.UpdateBalanceLabel(); // Bakiyeyi günceller
            frmRent.Show(); // Önceki formu gösterir
            this.Close(); // Bu formu kapatır

        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            lblMoney.Text =UserData.Money.ToString("0.00", CultureInfo.InvariantCulture); // Kullanıcı verilerinden bakiyeyi alır
            lblMoney.Visible = true; // Bakiyeyi görünür yapar
        }

        
        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            try {
                //mevcut bakiyeyi alır
                decimal amount = 0;
                decimal.TryParse(lblMoney.Text,out amount);
                //kullanıcının girdiği miktarı alır
                decimal addAmount = 0;
                if(!decimal.TryParse(txtMoney.Text, out addAmount) || addAmount <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir miktar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                UserData.Money += addAmount; // Kullanıcının bakiyesine ekleme yapar
                lblMoney.Text = UserData.Money.ToString("1000.00", CultureInfo.InvariantCulture); // Güncellenmiş bakiyeyi etiket üzerinde gösterir

                //bakiyeyi görünür yapar
                lblMoney.Visible = true;

                DialogResult result = MessageBox.Show("Bakiyeniz güncellendi. Yeni bakiyeniz: " + lblMoney.Text + " TL\nTekrar para eklemek ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                   frmRent.UpdateBalanceLabel(); // Bakiyeyi günceller
                    frmRent.Show(); // Önceki formu gösterir

                    this.Close();
                }
                else if (result == DialogResult.Yes)
                {
                    txtMoney.Clear();
                    txtMoney.Focus();
                }
            }
            catch {
                MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}

