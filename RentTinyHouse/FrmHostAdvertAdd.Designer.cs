namespace RentTinyHouse
{
    partial class FrmHostAdvertAdd
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
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            cbCity = new ComboBox();
            cbTown = new ComboBox();
            nudPrice = new NumericUpDown();
            nudGuests = new NumericUpDown();
            chkIsActive = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGuests).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTitle.Location = new Point(257, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(197, 34);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDescription.Location = new Point(257, 81);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(197, 34);
            txtDescription.TabIndex = 1;
            // 
            // cbCity
            // 
            cbCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbCity.FormattingEnabled = true;
            cbCity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbCity.Location = new Point(256, 147);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(198, 36);
            cbCity.TabIndex = 2;
            // 
            // cbTown
            // 
            cbTown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbTown.FormattingEnabled = true;
            cbTown.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbTown.Location = new Point(256, 210);
            cbTown.Name = "cbTown";
            cbTown.Size = new Size(198, 36);
            cbTown.TabIndex = 3;
            // 
            // nudPrice
            // 
            nudPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nudPrice.Location = new Point(256, 271);
            nudPrice.Margin = new Padding(2);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(198, 34);
            nudPrice.TabIndex = 4;
            // 
            // nudGuests
            // 
            nudGuests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nudGuests.Location = new Point(257, 322);
            nudGuests.Margin = new Padding(2);
            nudGuests.Name = "nudGuests";
            nudGuests.Size = new Size(197, 34);
            nudGuests.TabIndex = 5;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkIsActive.Location = new Point(257, 385);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(18, 17);
            chkIsActive.TabIndex = 6;
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(149, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 7;
            label1.Text = "Başlık:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(114, 82);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 8;
            label2.Text = "Açıklama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(195, 152);
            label3.Name = "label3";
            label3.Size = new Size(31, 31);
            label3.TabIndex = 9;
            label3.Text = "İl:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(172, 215);
            label4.Name = "label4";
            label4.Size = new Size(54, 31);
            label4.TabIndex = 10;
            label4.Text = "İlçe:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(74, 274);
            label5.Name = "label5";
            label5.Size = new Size(152, 31);
            label5.TabIndex = 11;
            label5.Text = "Günlük Ücret:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(109, 325);
            label6.Name = "label6";
            label6.Size = new Size(117, 31);
            label6.TabIndex = 12;
            label6.Text = "Kişi Sayısı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(149, 381);
            label7.Name = "label7";
            label7.Size = new Size(66, 31);
            label7.TabIndex = 13;
            label7.Text = "Aktif:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAdd.Location = new Point(599, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 46);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 16);
            button2.Name = "button2";
            button2.Size = new Size(67, 50);
            button2.TabIndex = 15;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmHostAdvertAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chkIsActive);
            Controls.Add(nudGuests);
            Controls.Add(nudPrice);
            Controls.Add(cbTown);
            Controls.Add(cbCity);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Name = "FrmHostAdvertAdd";
            Text = "FrmHostAdvertAdd";
            Load += FrmHostAdvertAdd_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtDescription;
        private ComboBox cbCity;
        private ComboBox cbTown;
        private NumericUpDown nudPrice;
        private NumericUpDown nudGuests;
        private CheckBox chkIsActive;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAdd;
        private Button button2;
    }
}