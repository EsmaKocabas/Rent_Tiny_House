namespace RentTinyHouse
{
    partial class FrmRegister
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
            txtPassword1 = new TextBox();
            txtEmail = new TextBox();
            mskNum = new MaskedTextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbPassword1 = new CheckBox();
            btnSignUp = new Button();
            cbPassword2 = new CheckBox();
            txtPassword2 = new TextBox();
            label6 = new Label();
            btnBack = new Button();
            label7 = new Label();
            cmbUserType = new ComboBox();
            label8 = new Label();
            pbUserImage = new PictureBox();
            btnAddImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pbUserImage).BeginInit();
            SuspendLayout();
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(191, 392);
            txtPassword1.Margin = new Padding(3, 4, 3, 4);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(145, 27);
            txtPassword1.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 309);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 27);
            txtEmail.TabIndex = 20;
            // 
            // mskNum
            // 
            mskNum.Location = new Point(191, 269);
            mskNum.Margin = new Padding(3, 4, 3, 4);
            mskNum.Mask = "000-000-00-00";
            mskNum.Name = "mskNum";
            mskNum.Size = new Size(145, 27);
            mskNum.TabIndex = 19;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(191, 227);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(145, 27);
            txtSurname.TabIndex = 18;
            // 
            // txtName
            // 
            txtName.Location = new Point(191, 177);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(145, 27);
            txtName.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(15, 269);
            label5.Name = "label5";
            label5.Size = new Size(182, 24);
            label5.TabIndex = 16;
            label5.Text = "Telefon Numarası:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(127, 392);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 15;
            label4.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(119, 309);
            label3.Name = "label3";
            label3.Size = new Size(68, 24);
            label3.TabIndex = 14;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(97, 227);
            label2.Name = "label2";
            label2.Size = new Size(91, 24);
            label2.TabIndex = 13;
            label2.Text = "Soyisim:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(131, 177);
            label1.Name = "label1";
            label1.Size = new Size(55, 24);
            label1.TabIndex = 12;
            label1.Text = "İsim:";
            // 
            // cbPassword1
            // 
            cbPassword1.AutoSize = true;
            cbPassword1.Location = new Point(319, 397);
            cbPassword1.Margin = new Padding(3, 4, 3, 4);
            cbPassword1.Name = "cbPassword1";
            cbPassword1.Size = new Size(18, 17);
            cbPassword1.TabIndex = 22;
            cbPassword1.UseVisualStyleBackColor = true;
            cbPassword1.CheckedChanged += cbPassword1_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaption;
            btnSignUp.Location = new Point(202, 493);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(98, 41);
            btnSignUp.TabIndex = 23;
            btnSignUp.Text = "Kayıt Ol";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click_1;
            // 
            // cbPassword2
            // 
            cbPassword2.AutoSize = true;
            cbPassword2.Location = new Point(319, 437);
            cbPassword2.Margin = new Padding(3, 4, 3, 4);
            cbPassword2.Name = "cbPassword2";
            cbPassword2.Size = new Size(18, 17);
            cbPassword2.TabIndex = 26;
            cbPassword2.UseVisualStyleBackColor = true;
            cbPassword2.CheckedChanged += cbPassword2_CheckedChanged;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(191, 431);
            txtPassword2.Margin = new Padding(3, 4, 3, 4);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(145, 27);
            txtPassword2.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(57, 434);
            label6.Name = "label6";
            label6.Size = new Size(128, 24);
            label6.TabIndex = 24;
            label6.Text = "Şifre Tekrar:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(15, 16);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 40);
            btnBack.TabIndex = 30;
            btnBack.Text = "🡸";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(59, 349);
            label7.Name = "label7";
            label7.Size = new Size(133, 24);
            label7.TabIndex = 31;
            label7.Text = "Kullanıcı Tip:";
            // 
            // cmbUserType
            // 
            cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "1", "2", "3" });
            cmbUserType.Location = new Point(191, 349);
            cmbUserType.Margin = new Padding(3, 4, 3, 4);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(145, 28);
            cmbUserType.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(93, 117);
            label8.Name = "label8";
            label8.Size = new Size(98, 24);
            label8.TabIndex = 34;
            label8.Text = "Fotoğraf:";
            // 
            // pbUserImage
            // 
            pbUserImage.Location = new Point(191, 85);
            pbUserImage.Margin = new Padding(3, 4, 3, 4);
            pbUserImage.Name = "pbUserImage";
            pbUserImage.Size = new Size(145, 84);
            pbUserImage.TabIndex = 35;
            pbUserImage.TabStop = false;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = SystemColors.ActiveCaption;
            btnAddImage.Location = new Point(343, 111);
            btnAddImage.Margin = new Padding(3, 4, 3, 4);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(119, 41);
            btnAddImage.TabIndex = 36;
            btnAddImage.Text = "Fotoğraf Yükle";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 600);
            Controls.Add(btnAddImage);
            Controls.Add(pbUserImage);
            Controls.Add(label8);
            Controls.Add(cmbUserType);
            Controls.Add(label7);
            Controls.Add(btnBack);
            Controls.Add(cbPassword2);
            Controls.Add(txtPassword2);
            Controls.Add(label6);
            Controls.Add(btnSignUp);
            Controls.Add(cbPassword1);
            Controls.Add(txtPassword1);
            Controls.Add(txtEmail);
            Controls.Add(mskNum);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRegister";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pbUserImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword1;
        private TextBox txtEmail;
        private MaskedTextBox mskNum;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox cbPassword1;
        private Button btnSignUp;
        private CheckBox cbPassword2;
        private TextBox txtPassword2;
        private Label label6;
        private Button btnBack;
        private Label label7;
        private ComboBox cmbUserType;
        private Label label8;
        private PictureBox pbUserImage;
        private Button btnAddImage;
    }
}