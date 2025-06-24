namespace RentTinyHouse
{
    partial class FrmHostAdvert
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
            btnAdvertAdd = new Button();
            btnAdvertUpdate = new Button();
            dataGridView1 = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdvertAdd
            // 
            btnAdvertAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAdvertAdd.Location = new Point(653, 57);
            btnAdvertAdd.Name = "btnAdvertAdd";
            btnAdvertAdd.Size = new Size(135, 43);
            btnAdvertAdd.TabIndex = 0;
            btnAdvertAdd.Text = "İlan Ekle";
            btnAdvertAdd.UseVisualStyleBackColor = true;
            btnAdvertAdd.Click += btnAdvertAdd_Click;
            // 
            // btnAdvertUpdate
            // 
            btnAdvertUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAdvertUpdate.Location = new Point(653, 152);
            btnAdvertUpdate.Name = "btnAdvertUpdate";
            btnAdvertUpdate.Size = new Size(135, 43);
            btnAdvertUpdate.TabIndex = 1;
            btnAdvertUpdate.Text = "İlan Güncelle";
            btnAdvertUpdate.UseVisualStyleBackColor = true;
            btnAdvertUpdate.Click += btnAdvertUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(624, 381);
            dataGridView1.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnBack.Location = new Point(12, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(53, 49);
            btnBack.TabIndex = 4;
            btnBack.Text = "←";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FrmHostAdvert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdvertUpdate);
            Controls.Add(btnAdvertAdd);
            Name = "FrmHostAdvert";
            Text = "FrmHostAdvert";
            Load += FrmHostAdvert_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdvertAdd;
        private Button btnAdvertUpdate;
        private DataGridView dataGridView1;
        private Button btnBack;
    }
}