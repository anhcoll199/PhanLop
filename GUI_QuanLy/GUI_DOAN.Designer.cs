namespace GUI_QuanLy
{
    partial class GUI_DOAN
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
            this.BangDoan = new System.Windows.Forms.DataGridView();
            this.btnDSKhach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BangDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // BangDoan
            // 
            this.BangDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangDoan.Location = new System.Drawing.Point(65, 156);
            this.BangDoan.Name = "BangDoan";
            this.BangDoan.Size = new System.Drawing.Size(639, 249);
            this.BangDoan.TabIndex = 0;
            // 
            // btnDSKhach
            // 
            this.btnDSKhach.Location = new System.Drawing.Point(453, 53);
            this.btnDSKhach.Name = "btnDSKhach";
            this.btnDSKhach.Size = new System.Drawing.Size(100, 47);
            this.btnDSKhach.TabIndex = 1;
            this.btnDSKhach.Text = "Danh sách khách hàng";
            this.btnDSKhach.UseVisualStyleBackColor = true;
            this.btnDSKhach.Click += new System.EventHandler(this.btnDSKhach_Click);
            // 
            // GUI_DOAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDSKhach);
            this.Controls.Add(this.BangDoan);
            this.Name = "GUI_DOAN";
            this.Text = "GUI_DOAN";
            this.Load += new System.EventHandler(this.GUI_DOAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangDoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BangDoan;
        private System.Windows.Forms.Button btnDSKhach;
    }
}