namespace RentTinyHouse
{
    partial class FrmAdmin
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            lblActiveUsers = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(48, 39);
            label1.Name = "label1";
            label1.Size = new Size(218, 26);
            label1.TabIndex = 0;
            label1.Text = "Aktif Kullanıcı Sayısı:";
            // 
            // lblActiveUsers
            // 
            lblActiveUsers.AutoSize = true;
            lblActiveUsers.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblActiveUsers.Location = new Point(272, 39);
            lblActiveUsers.Name = "lblActiveUsers";
            lblActiveUsers.Size = new Size(23, 26);
            lblActiveUsers.TabIndex = 1;
            lblActiveUsers.Text = "0";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(375, 39);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(396, 227);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(67, 85);
            button1.Name = "button1";
            button1.Size = new Size(173, 49);
            button1.TabIndex = 3;
            button1.Text = "Kullanıcılar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.Location = new Point(67, 152);
            button3.Name = "button3";
            button3.Size = new Size(173, 49);
            button3.TabIndex = 5;
            button3.Text = "Rezervasyonlar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(67, 217);
            button2.Name = "button2";
            button2.Size = new Size(173, 49);
            button2.TabIndex = 6;
            button2.Text = "İlan Yönetimi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button4.Location = new Point(67, 291);
            button4.Name = "button4";
            button4.Size = new Size(173, 49);
            button4.TabIndex = 7;
            button4.Text = "Ödeme Yönetimi";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button5.Location = new Point(67, 357);
            button5.Name = "button5";
            button5.Size = new Size(173, 49);
            button5.TabIndex = 8;
            button5.Text = "Rapor";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button6.Location = new Point(584, 357);
            button6.Name = "button6";
            button6.Size = new Size(173, 49);
            button6.TabIndex = 9;
            button6.Text = "Çıkış Yap";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(chart1);
            Controls.Add(lblActiveUsers);
            Controls.Add(label1);
            Name = "FrmAdmin";
            Text = "Kullanıcılar";
            Load += FrmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblActiveUsers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}