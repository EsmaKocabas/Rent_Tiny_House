namespace RentTinyHouse
{
    partial class FrmForgot
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
            cbPassword2 = new CheckBox();
            txtPassword2 = new TextBox();
            label6 = new Label();
            btnUpdate = new Button();
            cbPassword1 = new CheckBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbPassword2
            // 
            cbPassword2.AutoSize = true;
            cbPassword2.Location = new Point(373, 289);
            cbPassword2.Margin = new Padding(3, 4, 3, 4);
            cbPassword2.Name = "cbPassword2";
            cbPassword2.Size = new Size(18, 17);
            cbPassword2.TabIndex = 35;
            cbPassword2.UseVisualStyleBackColor = true;
            cbPassword2.CheckedChanged += cbPassword2_CheckedChanged;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(231, 283);
            txtPassword2.Margin = new Padding(3, 4, 3, 4);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(158, 27);
            txtPassword2.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(32, 283);
            label6.Name = "label6";
            label6.Size = new Size(211, 24);
            label6.TabIndex = 33;
            label6.Text = "Şifreyi Tekrar Giriniz:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(231, 341);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 41);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Şifre Değiştir";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button1_Click;
            // 
            // cbPassword1
            // 
            cbPassword1.AutoSize = true;
            cbPassword1.Location = new Point(373, 249);
            cbPassword1.Margin = new Padding(3, 4, 3, 4);
            cbPassword1.Name = "cbPassword1";
            cbPassword1.Size = new Size(18, 17);
            cbPassword1.TabIndex = 31;
            cbPassword1.UseVisualStyleBackColor = true;
            cbPassword1.CheckedChanged += cbPassword1_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 241);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(158, 27);
            txtPassword.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(231, 203);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 27);
            txtEmail.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(159, 244);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 28;
            label4.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(159, 203);
            label3.Name = "label3";
            label3.Size = new Size(68, 24);
            label3.TabIndex = 27;
            label3.Text = "Email:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.indir2;
            pictureBox1.Location = new Point(128, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 16);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 40);
            btnBack.TabIndex = 37;
            btnBack.Text = "🡸";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // FrmForgot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 600);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Controls.Add(cbPassword2);
            Controls.Add(txtPassword2);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(cbPassword1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmForgot";
            Text = "Forgot Password";
            Load += FrmForgot_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbPassword2;
        private TextBox txtPassword2;
        private Label label6;
        private Button btnUpdate;
        private CheckBox cbPassword1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnBack;
    }
}