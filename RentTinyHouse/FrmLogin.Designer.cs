namespace RentTinyHouse
{
    partial class FrmLogin
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            txtMail = new TextBox();
            txtPassword = new TextBox();
            cbPassword = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            button1 = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userProfile;
            pictureBox1.Location = new Point(136, 67);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(90, 265);
            label3.Name = "label3";
            label3.Size = new Size(68, 24);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(98, 312);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 4;
            label4.Text = "Şifre:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(162, 265);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(145, 27);
            txtMail.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(162, 312);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 27);
            txtPassword.TabIndex = 10;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(286, 318);
            cbPassword.Margin = new Padding(3, 4, 3, 4);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(18, 17);
            cbPassword.TabIndex = 11;
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 380);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 12;
            label6.Text = "Hesabın Yok Mu?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(136, 415);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 13;
            label7.Text = "Şifremi Unuttum";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(259, 380);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Ol";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(259, 415);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(95, 20);
            linkLabel2.TabIndex = 15;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Şifre Değiştir";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(168, 455);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 41);
            button1.TabIndex = 24;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 16);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 40);
            btnBack.TabIndex = 31;
            btnBack.Text = "🡸";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 600);
            Controls.Add(btnBack);
            Controls.Add(button1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtMail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox txtMail;
        private TextBox txtPassword;
        private CheckBox cbPassword;
        private Label label6;
        private Label label7;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button button1;
        private Button btnBack;
    }
}