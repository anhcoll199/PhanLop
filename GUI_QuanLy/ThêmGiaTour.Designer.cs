namespace GUI_QuanLy
{
    partial class ThêmGiaTour
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatour = new System.Windows.Forms.TextBox();
            this.txtMagia = new System.Windows.Forms.TextBox();
            this.txtBd = new System.Windows.Forms.DateTimePicker();
            this.txtKt = new System.Windows.Forms.DateTimePicker();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.txtKt);
            this.groupBox1.Controls.Add(this.txtBd);
            this.groupBox1.Controls.Add(this.txtMagia);
            this.groupBox1.Controls.Add(this.txtMatour);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật giá tour";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã tour";
            // 
            // txtMatour
            // 
            this.txtMatour.Location = new System.Drawing.Point(90, 23);
            this.txtMatour.Name = "txtMatour";
            this.txtMatour.Size = new System.Drawing.Size(100, 20);
            this.txtMatour.TabIndex = 5;
            // 
            // txtMagia
            // 
            this.txtMagia.Location = new System.Drawing.Point(323, 23);
            this.txtMagia.Name = "txtMagia";
            this.txtMagia.Size = new System.Drawing.Size(100, 20);
            this.txtMagia.TabIndex = 6;
            // 
            // txtBd
            // 
            this.txtBd.CustomFormat = "yyyy/MM/dd";
            this.txtBd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBd.Location = new System.Drawing.Point(115, 62);
            this.txtBd.Name = "txtBd";
            this.txtBd.Size = new System.Drawing.Size(120, 20);
            this.txtBd.TabIndex = 7;
            // 
            // txtKt
            // 
            this.txtKt.CustomFormat = "yyyy/MM/dd";
            this.txtKt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtKt.Location = new System.Drawing.Point(366, 62);
            this.txtKt.Name = "txtKt";
            this.txtKt.Size = new System.Drawing.Size(120, 20);
            this.txtKt.TabIndex = 8;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(90, 109);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 20);
            this.txtGia.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Nhập mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ThêmGiaTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThêmGiaTour";
            this.Text = "ThêmGiaTour";
            this.Load += new System.EventHandler(this.ThêmGiaTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatour;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DateTimePicker txtKt;
        private System.Windows.Forms.DateTimePicker txtBd;
        private System.Windows.Forms.TextBox txtMagia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}