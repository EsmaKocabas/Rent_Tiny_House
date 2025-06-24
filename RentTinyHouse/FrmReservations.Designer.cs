namespace RentTinyHouse
{
    partial class FrmReservations
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
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblPrice = new Label();
            label2 = new Label();
            lblStatus = new Label();
            tabControlReservations = new TabControl();
            tabPageActive = new TabPage();
            btnCancelReservation = new Button();
            dgvActiveReservations = new DataGridView();
            tabPagePast = new TabPage();
            dgvPastReservations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControlReservations.SuspendLayout();
            tabPageActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveReservations).BeginInit();
            tabPagePast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPastReservations).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 30);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "🡸";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 95);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(169, 76);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 28;
            label1.Text = "Toplam Tutar:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPrice.Location = new Point(278, 76);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 21);
            lblPrice.TabIndex = 29;
            lblPrice.Text = "label1";
            lblPrice.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(210, 106);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 30;
            label2.Text = "Durum:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblStatus.Location = new Point(278, 106);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 21);
            lblStatus.TabIndex = 31;
            lblStatus.Text = "label2";
            lblStatus.Visible = false;
            // 
            // tabControlReservations
            // 
            tabControlReservations.Controls.Add(tabPageActive);
            tabControlReservations.Controls.Add(tabPagePast);
            tabControlReservations.Location = new Point(3, 224);
            tabControlReservations.Name = "tabControlReservations";
            tabControlReservations.SelectedIndex = 0;
            tabControlReservations.Size = new Size(901, 174);
            tabControlReservations.TabIndex = 32;
            // 
            // tabPageActive
            // 
            tabPageActive.Controls.Add(btnCancelReservation);
            tabPageActive.Controls.Add(dgvActiveReservations);
            tabPageActive.Location = new Point(4, 24);
            tabPageActive.Name = "tabPageActive";
            tabPageActive.Padding = new Padding(3);
            tabPageActive.Size = new Size(893, 146);
            tabPageActive.TabIndex = 0;
            tabPageActive.Text = "Aktif Rezervasyonlar";
            tabPageActive.UseVisualStyleBackColor = true;
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.BackColor = SystemColors.ActiveCaption;
            btnCancelReservation.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 162);
            btnCancelReservation.Location = new Point(720, 111);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(167, 29);
            btnCancelReservation.TabIndex = 33;
            btnCancelReservation.Text = "Rezervasyon İptal Et";
            btnCancelReservation.UseVisualStyleBackColor = false;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // dgvActiveReservations
            // 
            dgvActiveReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveReservations.Location = new Point(-4, 0);
            dgvActiveReservations.Name = "dgvActiveReservations";
            dgvActiveReservations.Size = new Size(897, 146);
            dgvActiveReservations.TabIndex = 0;
            dgvActiveReservations.CellContentClick += dgvActiveReservations_CellContentClick;
            // 
            // tabPagePast
            // 
            tabPagePast.Controls.Add(dgvPastReservations);
            tabPagePast.Location = new Point(4, 24);
            tabPagePast.Name = "tabPagePast";
            tabPagePast.Padding = new Padding(3);
            tabPagePast.Size = new Size(893, 146);
            tabPagePast.TabIndex = 1;
            tabPagePast.Text = "Geçmiş Rezervasyonlar";
            tabPagePast.UseVisualStyleBackColor = true;
            // 
            // dgvPastReservations
            // 
            dgvPastReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPastReservations.Location = new Point(0, 0);
            dgvPastReservations.Name = "dgvPastReservations";
            dgvPastReservations.Size = new Size(893, 146);
            dgvPastReservations.TabIndex = 0;
            // 
            // FrmReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 450);
            Controls.Add(tabControlReservations);
            Controls.Add(lblStatus);
            Controls.Add(label2);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Name = "FrmReservations";
            Text = "Reservations";
            Load += FrmReservations_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControlReservations.ResumeLayout(false);
            tabPageActive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActiveReservations).EndInit();
            tabPagePast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPastReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblPrice;
        private Label label2;
        private Label lblStatus;
        private TabControl tabControlReservations;
        private TabPage tabPageActive;
        private TabPage tabPagePast;
        private Button btnCancelReservation;
        private DataGridView dgvActiveReservations;
        private DataGridView dgvPastReservations;
    }
}