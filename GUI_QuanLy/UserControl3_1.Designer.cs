﻿namespace GUI_QuanLy
{
    partial class UserControl3_1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDen = new System.Windows.Forms.DateTimePicker();
            this.Bang1 = new System.Windows.Forms.DataGridView();
            this.txtTu = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLan = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bang1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(111, 21);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(111, 21);
            this.cbbNhanVien.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSoLan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTenNhanVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtDen);
            this.panel1.Controls.Add(this.Bang1);
            this.panel1.Controls.Add(this.txtTu);
            this.panel1.Controls.Add(this.cbbNhanVien);
            this.panel1.Location = new System.Drawing.Point(13, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 315);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDen
            // 
            this.txtDen.CustomFormat = "yyyy/MM/dd";
            this.txtDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDen.Location = new System.Drawing.Point(449, 21);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(86, 20);
            this.txtDen.TabIndex = 3;
            // 
            // Bang1
            // 
            this.Bang1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bang1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bang1.Location = new System.Drawing.Point(29, 106);
            this.Bang1.Name = "Bang1";
            this.Bang1.Size = new System.Drawing.Size(522, 150);
            this.Bang1.TabIndex = 2;
            // 
            // txtTu
            // 
            this.txtTu.CustomFormat = "yyyy/MM/dd";
            this.txtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTu.Location = new System.Drawing.Point(341, 22);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(91, 20);
            this.txtTu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thời gian";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(111, 66);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txtTenNhanVien.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng số lần đi";
            // 
            // txtSoLan
            // 
            this.txtSoLan.Location = new System.Drawing.Point(350, 66);
            this.txtSoLan.Name = "txtSoLan";
            this.txtSoLan.Size = new System.Drawing.Size(64, 20);
            this.txtSoLan.TabIndex = 10;
            // 
            // UserControl3_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl3_1";
            this.Size = new System.Drawing.Size(580, 289);
            this.Load += new System.EventHandler(this.UserControl3_1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bang1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txtTu;
        private System.Windows.Forms.DataGridView Bang1;
        private System.Windows.Forms.DateTimePicker txtDen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLan;
        private System.Windows.Forms.Label label4;
    }
}