namespace GUI_QuanLy
{
    partial class DSKhachThuocDoan_GUI
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
            this.Bang = new System.Windows.Forms.DataGridView();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bang)).BeginInit();
            this.SuspendLayout();
            // 
            // Bang
            // 
            this.Bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bang.Location = new System.Drawing.Point(42, 140);
            this.Bang.Name = "Bang";
            this.Bang.Size = new System.Drawing.Size(461, 114);
            this.Bang.TabIndex = 0;
            // 
            // cbb1
            // 
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(85, 28);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(121, 21);
            this.cbb1.TabIndex = 1;
            this.cbb1.TextChanged += new System.EventHandler(this.cbb1_TextChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(443, 61);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // DSKhachThuocDoan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 280);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.Bang);
            this.Name = "DSKhachThuocDoan_GUI";
            this.Text = "DSKhachThuocDoan_GUI";
            this.Load += new System.EventHandler(this.DSKhachThuocDoan_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Bang;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.TextBox txt1;
    }
}