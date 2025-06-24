namespace RentTinyHouse
{
    partial class FrmHostAdvertUpdate
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
            dgvAdverts = new DataGridView();
            btnUpdate = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chkIsActive = new CheckBox();
            nudGuests = new NumericUpDown();
            nudPrice = new NumericUpDown();
            cbTown = new ComboBox();
            cbCity = new ComboBox();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdverts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGuests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // dgvAdverts
            // 
            dgvAdverts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdverts.Location = new Point(12, 70);
            dgvAdverts.Name = "dgvAdverts";
            dgvAdverts.RowHeadersWidth = 51;
            dgvAdverts.Size = new Size(327, 377);
            dgvAdverts.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnUpdate.Location = new Point(795, 185);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 46);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(437, 388);
            label7.Name = "label7";
            label7.Size = new Size(66, 31);
            label7.TabIndex = 28;
            label7.Text = "Aktif:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(397, 332);
            label6.Name = "label6";
            label6.Size = new Size(117, 31);
            label6.TabIndex = 27;
            label6.Text = "Kişi Sayısı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(362, 281);
            label5.Name = "label5";
            label5.Size = new Size(152, 31);
            label5.TabIndex = 26;
            label5.Text = "Günlük Ücret:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(460, 222);
            label4.Name = "label4";
            label4.Size = new Size(54, 31);
            label4.TabIndex = 25;
            label4.Text = "İlçe:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(483, 159);
            label3.Name = "label3";
            label3.Size = new Size(31, 31);
            label3.TabIndex = 24;
            label3.Text = "İl:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(402, 89);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 23;
            label2.Text = "Açıklama:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(437, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 22;
            label1.Text = "Başlık:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkIsActive.Location = new Point(545, 392);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(18, 17);
            chkIsActive.TabIndex = 21;
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // nudGuests
            // 
            nudGuests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nudGuests.Location = new Point(545, 329);
            nudGuests.Margin = new Padding(2);
            nudGuests.Name = "nudGuests";
            nudGuests.Size = new Size(197, 34);
            nudGuests.TabIndex = 20;
            // 
            // nudPrice
            // 
            nudPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            nudPrice.Location = new Point(544, 278);
            nudPrice.Margin = new Padding(2);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(198, 34);
            nudPrice.TabIndex = 19;
            // 
            // cbTown
            // 
            cbTown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbTown.FormattingEnabled = true;
            cbTown.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbTown.Location = new Point(544, 217);
            cbTown.Name = "cbTown";
            cbTown.Size = new Size(198, 36);
            cbTown.TabIndex = 18;
            // 
            // cbCity
            // 
            cbCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbCity.FormattingEnabled = true;
            cbCity.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbCity.Location = new Point(544, 154);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(198, 36);
            cbCity.TabIndex = 17;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDescription.Location = new Point(545, 88);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(197, 34);
            txtDescription.TabIndex = 16;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtTitle.Location = new Point(545, 23);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(197, 34);
            txtTitle.TabIndex = 15;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 7);
            button2.Name = "button2";
            button2.Size = new Size(65, 50);
            button2.TabIndex = 30;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmHostAdvertUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 450);
            Controls.Add(button2);
            Controls.Add(btnUpdate);
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
            Controls.Add(dgvAdverts);
            Name = "FrmHostAdvertUpdate";
            Text = "FrmHostAdvertUpdate";
            Load += FrmHostAdvertUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdverts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGuests).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAdverts;
        private Button btnUpdate;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkIsActive;
        private NumericUpDown nudGuests;
        private NumericUpDown nudPrice;
        private ComboBox cbTown;
        private ComboBox cbCity;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private Button button2;
    }
}