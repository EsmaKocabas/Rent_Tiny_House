namespace RentTinyHouse
{
    partial class FrmPayment
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
            label1 = new Label();
            label2 = new Label();
            lblMoney = new Label();
            btnAddMoney = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtMoney = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(63, 16);
            label1.Name = "label1";
            label1.Size = new Size(233, 37);
            label1.TabIndex = 0;
            label1.Text = "SANAL CÜZDAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(25, 84);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 1;
            label2.Text = "Cüzdanınızdaki Para:";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMoney.Location = new Point(206, 84);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(65, 28);
            lblMoney.TabIndex = 2;
            lblMoney.Text = "label3";
            lblMoney.Visible = false;
            // 
            // btnAddMoney
            // 
            btnAddMoney.BackColor = SystemColors.ActiveCaption;
            btnAddMoney.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddMoney.ForeColor = SystemColors.InactiveCaptionText;
            btnAddMoney.Location = new Point(336, 220);
            btnAddMoney.Margin = new Padding(3, 4, 3, 4);
            btnAddMoney.Name = "btnAddMoney";
            btnAddMoney.Size = new Size(81, 29);
            btnAddMoney.TabIndex = 25;
            btnAddMoney.Text = "Para Ekle";
            btnAddMoney.UseVisualStyleBackColor = false;
            btnAddMoney.Click += btnAddMoney_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.indir__1_;
            pictureBox1.Location = new Point(-3, 307);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(25, 181);
            label3.Name = "label3";
            label3.Size = new Size(284, 28);
            label3.TabIndex = 27;
            label3.Text = "Eklemek İstediğiniz Tutarı Girin:";
            // 
            // txtMoney
            // 
            txtMoney.Location = new Point(315, 182);
            txtMoney.Margin = new Padding(3, 4, 3, 4);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(125, 27);
            txtMoney.TabIndex = 28;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(8, 16);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 40);
            btnBack.TabIndex = 29;
            btnBack.Text = "🡸";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 491);
            Controls.Add(btnBack);
            Controls.Add(txtMoney);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddMoney);
            Controls.Add(lblMoney);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPayment";
            Text = "Payment";
            Load += FrmPayment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblMoney;
        private Button btnAddMoney;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtMoney;
        private Button btnBack;
    }
}