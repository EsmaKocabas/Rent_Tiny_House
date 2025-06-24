namespace RentTinyHouse
{
    partial class FrmAdminAdvertEdit
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtPrice = new TextBox();
            txtLocation = new TextBox();
            button1 = new Button();
            dtpDate = new DateTimePicker();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(219, 47);
            label1.Name = "label1";
            label1.Size = new Size(61, 31);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(177, 121);
            label2.Name = "label2";
            label2.Size = new Size(103, 31);
            label2.TabIndex = 1;
            label2.Text = "Soy İsim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(213, 268);
            label3.Name = "label3";
            label3.Size = new Size(67, 31);
            label3.TabIndex = 2;
            label3.Text = "Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(206, 194);
            label4.Name = "label4";
            label4.Size = new Size(74, 31);
            label4.TabIndex = 3;
            label4.Text = "Ücret:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(190, 326);
            label5.Name = "label5";
            label5.Size = new Size(90, 31);
            label5.TabIndex = 4;
            label5.Text = "Konum:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtName.Location = new Point(307, 44);
            txtName.Name = "txtName";
            txtName.Size = new Size(228, 34);
            txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSurname.Location = new Point(307, 118);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(228, 34);
            txtSurname.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtPrice.Location = new Point(307, 194);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(149, 34);
            txtPrice.TabIndex = 7;
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtLocation.Location = new Point(307, 323);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(228, 34);
            txtLocation.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(307, 376);
            button1.Name = "button1";
            button1.Size = new Size(228, 50);
            button1.TabIndex = 10;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpDate.Location = new Point(307, 268);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(312, 34);
            dtpDate.TabIndex = 11;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(67, 50);
            button2.TabIndex = 12;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmAdminAdvertEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dtpDate);
            Controls.Add(button1);
            Controls.Add(txtLocation);
            Controls.Add(txtPrice);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAdminAdvertEdit";
            Text = "FrmAdminAdvertEdit";
            Load += FrmAdminAdvertEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtPrice;
        private TextBox txtLocation;
        private Button button1;
        private DateTimePicker dtpDate;
        private Button button2;
    }
}