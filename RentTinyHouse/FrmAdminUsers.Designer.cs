namespace RentTinyHouse
{
    partial class FrmAdminUsers
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
            txtFilter = new TextBox();
            button1 = new Button();
            dtgUser = new DataGridView();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgUser).BeginInit();
            SuspendLayout();
            // 
            // txtFilter
            // 
            txtFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtFilter.Location = new Point(539, 12);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(151, 34);
            txtFilter.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(708, 6);
            button1.Name = "button1";
            button1.Size = new Size(63, 40);
            button1.TabIndex = 1;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtgUser
            // 
            dtgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUser.Location = new Point(25, 62);
            dtgUser.Name = "dtgUser";
            dtgUser.RowHeadersWidth = 51;
            dtgUser.Size = new Size(746, 340);
            dtgUser.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(25, 6);
            button2.Name = "button2";
            button2.Size = new Size(58, 50);
            button2.TabIndex = 3;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmAdminUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dtgUser);
            Controls.Add(button1);
            Controls.Add(txtFilter);
            Name = "FrmAdminUsers";
            Text = "FrmAdminUsers";
            Load += FrmAdminUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilter;
        private Button button1;
        private DataGridView dtgUser;
        private Button button2;
    }
}