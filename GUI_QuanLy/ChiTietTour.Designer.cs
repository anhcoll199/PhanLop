namespace GUI_QuanLy
{
    partial class ChiTietTour
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBack = new System.Windows.Forms.Button();
            this.BangDiaDiem = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnThemPhieu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.MADD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiaDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtBack);
            this.groupBox1.Controls.Add(this.BangDiaDiem);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.BtnThemPhieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaTour);
            this.groupBox1.Controls.Add(this.btnGo);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm chi tiết tour";
            // 
            // txtBack
            // 
            this.txtBack.Location = new System.Drawing.Point(274, 162);
            this.txtBack.Name = "txtBack";
            this.txtBack.Size = new System.Drawing.Size(51, 23);
            this.txtBack.TabIndex = 9;
            this.txtBack.Text = "Bỏ";
            this.txtBack.UseVisualStyleBackColor = true;
            this.txtBack.Click += new System.EventHandler(this.txtBack_Click);
            // 
            // BangDiaDiem
            // 
            this.BangDiaDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangDiaDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangDiaDiem.Location = new System.Drawing.Point(6, 92);
            this.BangDiaDiem.Name = "BangDiaDiem";
            this.BangDiaDiem.Size = new System.Drawing.Size(262, 133);
            this.BangDiaDiem.TabIndex = 8;
            this.BangDiaDiem.Click += new System.EventHandler(this.BangDiaDiem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADD,
            this.TENDD});
            this.dataGridView2.Location = new System.Drawing.Point(331, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(265, 133);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // BtnThemPhieu
            // 
            this.BtnThemPhieu.Location = new System.Drawing.Point(249, 43);
            this.BtnThemPhieu.Name = "BtnThemPhieu";
            this.BtnThemPhieu.Size = new System.Drawing.Size(97, 29);
            this.BtnThemPhieu.TabIndex = 6;
            this.BtnThemPhieu.Text = "Thêm Chi Tiết";
            this.BtnThemPhieu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã Tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // txtMaTour
            // 
            this.txtMaTour.Location = new System.Drawing.Point(105, 43);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(94, 20);
            this.txtMaTour.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(274, 124);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(51, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Chọn";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // MADD
            // 
            this.MADD.HeaderText = "Mã địa điểm";
            this.MADD.Name = "MADD";
            // 
            // TENDD
            // 
            this.TENDD.HeaderText = "Tên địa điểm";
            this.TENDD.Name = "TENDD";
            // 
            // ChiTietTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 306);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChiTietTour";
            this.Text = "ChiTietTour";
            this.Load += new System.EventHandler(this.ChiTietTour_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BangDiaDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnThemPhieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridView BangDiaDiem;
        private System.Windows.Forms.Button txtBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDD;
    }
}