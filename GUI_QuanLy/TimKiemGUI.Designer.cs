namespace GUI_QuanLy
{
    partial class TimKiemGUI
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
            this.BangTimKiem = new System.Windows.Forms.DataGridView();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BangTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // BangTimKiem
            // 
            this.BangTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangTimKiem.Location = new System.Drawing.Point(94, 145);
            this.BangTimKiem.Name = "BangTimKiem";
            this.BangTimKiem.Size = new System.Drawing.Size(608, 178);
            this.BangTimKiem.TabIndex = 0;
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
            "1. Tìm kiếm thông tin về khách hàng.",
            "2. Tìm kiếm thông tin về 1 đoàn.",
            "3. Tìm kiếm thông tin về 1 tour."});
            this.cbb1.Location = new System.Drawing.Point(82, 61);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(322, 21);
            this.cbb1.TabIndex = 1;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(579, 62);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(684, 97);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // TimKiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.BangTimKiem);
            this.Name = "TimKiemGUI";
            this.Text = "KhachGUI";
            ((System.ComponentModel.ISupportInitialize)(this.BangTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BangTimKiem;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnTim;
    }
}