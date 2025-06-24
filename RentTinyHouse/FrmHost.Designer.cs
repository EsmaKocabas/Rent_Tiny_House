namespace RentTinyHouse
{
    partial class FrmHost
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
            btnAdvert = new Button();
            btnReservation = new Button();
            btnPayment = new Button();
            btnReview = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnAdvert
            // 
            btnAdvert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAdvert.Location = new Point(287, 62);
            btnAdvert.Name = "btnAdvert";
            btnAdvert.Size = new Size(166, 52);
            btnAdvert.TabIndex = 0;
            btnAdvert.Text = "İlan Durumu";
            btnAdvert.UseVisualStyleBackColor = true;
            btnAdvert.Click += btnAdvert_Click;
            // 
            // btnReservation
            // 
            btnReservation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnReservation.Location = new Point(287, 143);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(166, 52);
            btnReservation.TabIndex = 1;
            btnReservation.Text = "Rezervasyonlar";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnPayment.Location = new Point(287, 230);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(166, 52);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Ödemeler";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnReview
            // 
            btnReview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnReview.Location = new Point(287, 315);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(166, 52);
            btnReview.TabIndex = 3;
            btnReview.Text = "Yorumlar";
            btnReview.UseVisualStyleBackColor = true;
            btnReview.Click += btnReview_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(65, 50);
            button2.TabIndex = 31;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmHost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnReview);
            Controls.Add(btnPayment);
            Controls.Add(btnReservation);
            Controls.Add(btnAdvert);
            Name = "FrmHost";
            Text = "FrmHost";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdvert;
        private Button btnReservation;
        private Button btnPayment;
        private Button btnReview;
        private Button button2;
    }
}