namespace RentTinyHouse
{
    partial class FrmRent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox3 = new PictureBox();
            btnPayment = new Button();
            btnRent = new Button();
            label2 = new Label();
            lblMoney = new Label();
            label1 = new Label();
            lblPrice = new Label();
            btnBack = new Button();
            dtpStart = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblDailyRate = new Label();
            cmbHouses = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.giphy;
            pictureBox3.Location = new Point(14, 385);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = SystemColors.ActiveCaption;
            btnPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPayment.ForeColor = SystemColors.ActiveCaptionText;
            btnPayment.Location = new Point(162, 521);
            btnPayment.Margin = new Padding(3, 4, 3, 4);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(185, 37);
            btnPayment.TabIndex = 23;
            btnPayment.Text = "Ödeme İşlemleri";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnRent
            // 
            btnRent.BackColor = SystemColors.ActiveCaption;
            btnRent.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRent.ForeColor = SystemColors.InactiveCaptionText;
            btnRent.Location = new Point(162, 316);
            btnRent.Margin = new Padding(3, 4, 3, 4);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(185, 39);
            btnRent.TabIndex = 24;
            btnRent.Text = "Kirala";
            btnRent.UseVisualStyleBackColor = false;
            btnRent.Click += btnRent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 284);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 25;
            label2.Text = "Cüzdanınızdaki Para:";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMoney.Location = new Point(193, 284);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(65, 28);
            lblMoney.TabIndex = 26;
            lblMoney.Text = "label3";
            lblMoney.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(65, 244);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 27;
            label1.Text = "Toplam Tutar:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPrice.Location = new Point(193, 244);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 28);
            lblPrice.TabIndex = 28;
            lblPrice.Text = "label4";
            lblPrice.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 16);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(79, 29);
            btnBack.TabIndex = 29;
            btnBack.Text = "🡸";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(30, 127);
            dtpStart.Margin = new Padding(3, 4, 3, 4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(189, 27);
            dtpStart.TabIndex = 30;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(239, 127);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(189, 27);
            dtpEndDate.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(69, 77);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 32;
            label3.Text = "Başlangıç Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(272, 77);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 33;
            label4.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(65, 203);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 34;
            label5.Text = "Günlük Fiyat:";
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDailyRate.Location = new Point(193, 203);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(45, 28);
            lblDailyRate.TabIndex = 35;
            lblDailyRate.Text = "100";
            // 
            // cmbHouses
            // 
            cmbHouses.FormattingEnabled = true;
            cmbHouses.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbHouses.Location = new Point(196, 169);
            cmbHouses.Name = "cmbHouses";
            cmbHouses.Size = new Size(151, 28);
            cmbHouses.TabIndex = 36;
            // 
            // FrmRent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 600);
            Controls.Add(cmbHouses);
            Controls.Add(lblDailyRate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStart);
            Controls.Add(btnBack);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(lblMoney);
            Controls.Add(label2);
            Controls.Add(btnRent);
            Controls.Add(btnPayment);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRent";
            Text = "FrmRent";
            Load += FrmRent_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Button btnPayment;
        private Button btnRent;
        private Label label2;
        private Label lblMoney;
        private Label label1;
        private Label lblPrice;
        private Button btnBack;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEndDate;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblDailyRate;
        private ComboBox cmbHouses;
    }
}