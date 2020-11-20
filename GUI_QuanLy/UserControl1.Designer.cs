namespace GUI_QuanLy
{
    partial class UserControl1
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
            this.BangDoan = new System.Windows.Forms.DataGridView();
            this.btnDSKhach = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKT = new System.Windows.Forms.DateTimePicker();
            this.txtBD = new System.Windows.Forms.DateTimePicker();
            this.cbbMaTour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDoan = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BangDoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BangDoan
            // 
            this.BangDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BangDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BangDoan.Location = new System.Drawing.Point(3, 165);
            this.BangDoan.Name = "BangDoan";
            this.BangDoan.Size = new System.Drawing.Size(596, 246);
            this.BangDoan.TabIndex = 1;
            this.BangDoan.Click += new System.EventHandler(this.BangDoan_Click);
            // 
            // btnDSKhach
            // 
            this.btnDSKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSKhach.Location = new System.Drawing.Point(398, 76);
            this.btnDSKhach.Name = "btnDSKhach";
            this.btnDSKhach.Size = new System.Drawing.Size(53, 45);
            this.btnDSKhach.TabIndex = 2;
            this.btnDSKhach.Text = "Danh sách khách hàng";
            this.btnDSKhach.UseVisualStyleBackColor = true;
            this.btnDSKhach.Click += new System.EventHandler(this.btnDSKhach_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKT);
            this.groupBox1.Controls.Add(this.txtBD);
            this.groupBox1.Controls.Add(this.cbbMaTour);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaDoan);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Đoàn khách";
            // 
            // txtKT
            // 
            this.txtKT.CustomFormat = "yyyy/MM/dd";
            this.txtKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtKT.Location = new System.Drawing.Point(226, 49);
            this.txtKT.Name = "txtKT";
            this.txtKT.Size = new System.Drawing.Size(84, 20);
            this.txtKT.TabIndex = 7;
            // 
            // txtBD
            // 
            this.txtBD.CustomFormat = "yyyy/MM/dd";
            this.txtBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBD.Location = new System.Drawing.Point(101, 49);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(84, 20);
            this.txtBD.TabIndex = 6;
            // 
            // cbbMaTour
            // 
            this.cbbMaTour.FormattingEnabled = true;
            this.cbbMaTour.Location = new System.Drawing.Point(101, 76);
            this.cbbMaTour.Name = "cbbMaTour";
            this.cbbMaTour.Size = new System.Drawing.Size(121, 21);
            this.cbbMaTour.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đoàn";
            // 
            // txtMaDoan
            // 
            this.txtMaDoan.Location = new System.Drawing.Point(101, 19);
            this.txtMaDoan.Name = "txtMaDoan";
            this.txtMaDoan.Size = new System.Drawing.Size(280, 20);
            this.txtMaDoan.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(398, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(457, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 45);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(516, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 45);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDSKhach);
            this.Controls.Add(this.BangDoan);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(602, 441);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BangDoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BangDoan;
        private System.Windows.Forms.Button btnDSKhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbMaTour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDoan;
        private System.Windows.Forms.DateTimePicker txtKT;
        private System.Windows.Forms.DateTimePicker txtBD;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
