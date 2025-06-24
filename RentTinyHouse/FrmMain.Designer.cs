namespace RentTinyHouse
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            houseImage1 = new PictureBox();
            houseImage2 = new PictureBox();
            houseImage3 = new PictureBox();
            btnKirala1 = new Button();
            btnKirala2 = new Button();
            btnKirala3 = new Button();
            btnReview1 = new Button();
            btnReview2 = new Button();
            btnReview3 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btnReservations = new Button();
            pictureBox2 = new PictureBox();
            btnPopuler = new Button();
            pictureBox4 = new PictureBox();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)houseImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)houseImage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)houseImage3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // houseImage1
            // 
            houseImage1.Image = Properties.Resources.bungalov;
            houseImage1.Location = new Point(53, 101);
            houseImage1.Margin = new Padding(3, 4, 3, 4);
            houseImage1.Name = "houseImage1";
            houseImage1.Size = new Size(242, 218);
            houseImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            houseImage1.TabIndex = 0;
            houseImage1.TabStop = false;
            // 
            // houseImage2
            // 
            houseImage2.Image = Properties.Resources.dublex;
            houseImage2.Location = new Point(338, 101);
            houseImage2.Margin = new Padding(3, 4, 3, 4);
            houseImage2.Name = "houseImage2";
            houseImage2.Size = new Size(242, 218);
            houseImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            houseImage2.TabIndex = 1;
            houseImage2.TabStop = false;
            // 
            // houseImage3
            // 
            houseImage3.Image = Properties.Resources.ormanevi;
            houseImage3.Location = new Point(651, 101);
            houseImage3.Margin = new Padding(3, 4, 3, 4);
            houseImage3.Name = "houseImage3";
            houseImage3.Size = new Size(242, 218);
            houseImage3.SizeMode = PictureBoxSizeMode.StretchImage;
            houseImage3.TabIndex = 2;
            houseImage3.TabStop = false;
            // 
            // btnKirala1
            // 
            btnKirala1.BackColor = SystemColors.ActiveCaption;
            btnKirala1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnKirala1.ForeColor = SystemColors.InactiveCaptionText;
            btnKirala1.Location = new Point(53, 344);
            btnKirala1.Margin = new Padding(3, 4, 3, 4);
            btnKirala1.Name = "btnKirala1";
            btnKirala1.Size = new Size(124, 39);
            btnKirala1.TabIndex = 3;
            btnKirala1.Text = "Kirala";
            btnKirala1.UseVisualStyleBackColor = false;
            btnKirala1.Click += btnKirala1_Click;
            // 
            // btnKirala2
            // 
            btnKirala2.BackColor = SystemColors.ActiveCaption;
            btnKirala2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnKirala2.ForeColor = SystemColors.InactiveCaptionText;
            btnKirala2.Location = new Point(338, 344);
            btnKirala2.Margin = new Padding(3, 4, 3, 4);
            btnKirala2.Name = "btnKirala2";
            btnKirala2.Size = new Size(117, 39);
            btnKirala2.TabIndex = 4;
            btnKirala2.Text = "Kirala";
            btnKirala2.UseVisualStyleBackColor = false;
            btnKirala2.Click += btnKirala2_Click;
            // 
            // btnKirala3
            // 
            btnKirala3.BackColor = SystemColors.ActiveCaption;
            btnKirala3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnKirala3.ForeColor = SystemColors.InactiveCaptionText;
            btnKirala3.Location = new Point(651, 345);
            btnKirala3.Margin = new Padding(3, 4, 3, 4);
            btnKirala3.Name = "btnKirala3";
            btnKirala3.Size = new Size(122, 39);
            btnKirala3.TabIndex = 5;
            btnKirala3.Text = "Kirala";
            btnKirala3.UseVisualStyleBackColor = false;
            btnKirala3.Click += btnKirala3_Click;
            // 
            // btnReview1
            // 
            btnReview1.Font = new Font("Segoe UI", 8.25F);
            btnReview1.Location = new Point(200, 344);
            btnReview1.Margin = new Padding(3, 4, 3, 4);
            btnReview1.Name = "btnReview1";
            btnReview1.Size = new Size(95, 39);
            btnReview1.TabIndex = 15;
            btnReview1.Text = "Yorum Yap";
            btnReview1.UseVisualStyleBackColor = true;
            btnReview1.Click += btnReview1_Click;
            // 
            // btnReview2
            // 
            btnReview2.Font = new Font("Segoe UI", 8.25F);
            btnReview2.Location = new Point(477, 345);
            btnReview2.Margin = new Padding(3, 4, 3, 4);
            btnReview2.Name = "btnReview2";
            btnReview2.Size = new Size(103, 36);
            btnReview2.TabIndex = 16;
            btnReview2.Text = "Yorum Yap";
            btnReview2.UseVisualStyleBackColor = true;
            btnReview2.Click += btnReview2_Click;
            // 
            // btnReview3
            // 
            btnReview3.Font = new Font("Segoe UI", 8.25F);
            btnReview3.Location = new Point(804, 347);
            btnReview3.Margin = new Padding(3, 4, 3, 4);
            btnReview3.Name = "btnReview3";
            btnReview3.Size = new Size(89, 37);
            btnReview3.TabIndex = 17;
            btnReview3.Text = "Yorum Yap";
            btnReview3.UseVisualStyleBackColor = true;
            btnReview3.Click += btnReview3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-1, 645);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 175);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.rent;
            pictureBox1.Location = new Point(973, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.InfoText;
            label5.Location = new Point(3, 55);
            label5.Name = "label5";
            label5.Size = new Size(975, 39);
            label5.TabIndex = 19;
            label5.Text = "TINY HOUSE KİRALAMA UYGULAMASINA HOŞ GELDİNİZ!";
            // 
            // btnReservations
            // 
            btnReservations.BackColor = SystemColors.ActiveCaption;
            btnReservations.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReservations.ForeColor = SystemColors.ActiveCaptionText;
            btnReservations.Location = new Point(1024, 248);
            btnReservations.Margin = new Padding(3, 4, 3, 4);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(127, 37);
            btnReservations.TabIndex = 19;
            btnReservations.Text = "Rezervasyonlar";
            btnReservations.UseVisualStyleBackColor = false;
            btnReservations.Click += btnReservations_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.indir;
            pictureBox2.Location = new Point(1024, 107);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // btnPopuler
            // 
            btnPopuler.BackColor = SystemColors.ActiveCaption;
            btnPopuler.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPopuler.ForeColor = SystemColors.ActiveCaptionText;
            btnPopuler.Location = new Point(1024, 481);
            btnPopuler.Margin = new Padding(3, 4, 3, 4);
            btnPopuler.Name = "btnPopuler";
            btnPopuler.Size = new Size(122, 37);
            btnPopuler.TabIndex = 38;
            btnPopuler.Text = "Popüler Evler";
            btnPopuler.UseVisualStyleBackColor = false;
            btnPopuler.Click += btnPopuler_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.yıldız;
            pictureBox4.Location = new Point(1024, 328);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(122, 121);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = SystemColors.ActiveCaption;
            btnLogOut.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            btnLogOut.ForeColor = SystemColors.InactiveCaptionText;
            btnLogOut.Location = new Point(1024, 13);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(122, 39);
            btnLogOut.TabIndex = 40;
            btnLogOut.Text = "Çıkış Yap";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 817);
            Controls.Add(btnLogOut);
            Controls.Add(pictureBox4);
            Controls.Add(btnPopuler);
            Controls.Add(pictureBox2);
            Controls.Add(btnReservations);
            Controls.Add(panel1);
            Controls.Add(btnReview3);
            Controls.Add(btnReview2);
            Controls.Add(btnReview1);
            Controls.Add(btnKirala3);
            Controls.Add(btnKirala2);
            Controls.Add(btnKirala1);
            Controls.Add(houseImage3);
            Controls.Add(houseImage2);
            Controls.Add(houseImage1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            Text = "MainPage";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)houseImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)houseImage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)houseImage3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox houseImage1;
        private PictureBox houseImage2;
        private PictureBox houseImage3;
        private Button btnKirala1;
        private Button btnKirala2;
        private Button btnKirala3;
        private Button btnReview1;
        private Button btnReview2;
        private Button btnReview3;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnReservations;
        private PictureBox pictureBox2;
        private Button btnPopuler;
        private PictureBox pictureBox4;
        private Button btnLogOut;
    }
}
