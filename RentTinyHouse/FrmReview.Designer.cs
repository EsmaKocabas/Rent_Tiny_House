namespace RentTinyHouse
{
    partial class FrmReview
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
            txtReview = new RichTextBox();
            btnReview = new Button();
            trackScore = new TrackBar();
            btnScore = new Button();
            lblScore = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)trackScore).BeginInit();
            SuspendLayout();
            // 
            // txtReview
            // 
            txtReview.Location = new Point(21, 239);
            txtReview.Name = "txtReview";
            txtReview.Size = new Size(297, 72);
            txtReview.TabIndex = 0;
            txtReview.Text = "";
            // 
            // btnReview
            // 
            btnReview.BackColor = SystemColors.GradientInactiveCaption;
            btnReview.Location = new Point(233, 317);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(85, 23);
            btnReview.TabIndex = 1;
            btnReview.Text = "Yorum Yap";
            btnReview.UseVisualStyleBackColor = false;
            btnReview.Click += btnReview_Click_1;
            // 
            // trackScore
            // 
            trackScore.BackColor = SystemColors.ButtonHighlight;
            trackScore.LargeChange = 1;
            trackScore.Location = new Point(21, 65);
            trackScore.Maximum = 5;
            trackScore.Minimum = 1;
            trackScore.Name = "trackScore";
            trackScore.Size = new Size(297, 45);
            trackScore.TabIndex = 2;
            trackScore.Value = 1;
            trackScore.Scroll += trackScore_Scroll;
            // 
            // btnScore
            // 
            btnScore.BackColor = SystemColors.GradientInactiveCaption;
            btnScore.Location = new Point(233, 147);
            btnScore.Name = "btnScore";
            btnScore.Size = new Size(85, 23);
            btnScore.TabIndex = 3;
            btnScore.Text = "Puanı Kaydet";
            btnScore.UseVisualStyleBackColor = false;
            btnScore.Click += btnScore_Click_1;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(35, 151);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(38, 15);
            lblScore.TabIndex = 4;
            lblScore.Text = "label1";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(61, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "🡸";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // FrmReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(423, 450);
            Controls.Add(btnBack);
            Controls.Add(lblScore);
            Controls.Add(btnScore);
            Controls.Add(trackScore);
            Controls.Add(btnReview);
            Controls.Add(txtReview);
            Name = "FrmReview";
            Text = "Review";
            Load += FrmReview_Load;
            ((System.ComponentModel.ISupportInitialize)trackScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtReview;
        private Button btnReview;
        private TrackBar trackScore;
        private Button btnScore;
        private Label lblScore;
        private Button btnBack;
    }
}