namespace GUI_QuanLy
{
    partial class UserControl3
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
            this.btnSoLanDiTour = new System.Windows.Forms.Button();
            this.btnThongKeCP = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.userControl3_31 = new GUI_QuanLy.UserControl3_3();
            this.userControl3_21 = new GUI_QuanLy.UserControl3_2();
            this.userControl3_11 = new GUI_QuanLy.UserControl3_1();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoLanDiTour
            // 
            this.btnSoLanDiTour.Location = new System.Drawing.Point(7, 3);
            this.btnSoLanDiTour.Name = "btnSoLanDiTour";
            this.btnSoLanDiTour.Size = new System.Drawing.Size(229, 23);
            this.btnSoLanDiTour.TabIndex = 6;
            this.btnSoLanDiTour.Text = "Số lần đi tour của nhân viên trong thời gian";
            this.btnSoLanDiTour.UseVisualStyleBackColor = true;
            this.btnSoLanDiTour.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnThongKeCP
            // 
            this.btnThongKeCP.Location = new System.Drawing.Point(306, 3);
            this.btnThongKeCP.Name = "btnThongKeCP";
            this.btnThongKeCP.Size = new System.Drawing.Size(126, 23);
            this.btnThongKeCP.TabIndex = 8;
            this.btnThongKeCP.Text = "Thống kê chi phí tour";
            this.btnThongKeCP.UseVisualStyleBackColor = true;
            this.btnThongKeCP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Location = new System.Drawing.Point(7, 49);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(132, 23);
            this.btnDoanhThu.TabIndex = 10;
            this.btnDoanhThu.Text = "Thống kê doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl3_31
            // 
            this.userControl3_31.Location = new System.Drawing.Point(7, 78);
            this.userControl3_31.Name = "userControl3_31";
            this.userControl3_31.Size = new System.Drawing.Size(576, 361);
            this.userControl3_31.TabIndex = 11;
            this.userControl3_31.Load += new System.EventHandler(this.userControl3_31_Load);
            // 
            // userControl3_21
            // 
            this.userControl3_21.Location = new System.Drawing.Point(30, 71);
            this.userControl3_21.Name = "userControl3_21";
            this.userControl3_21.Size = new System.Drawing.Size(553, 354);
            this.userControl3_21.TabIndex = 9;
            // 
            // userControl3_11
            // 
            this.userControl3_11.Location = new System.Drawing.Point(3, 49);
            this.userControl3_11.Name = "userControl3_11";
            this.userControl3_11.Size = new System.Drawing.Size(580, 376);
            this.userControl3_11.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thống kê doanh số";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl3_31);
            this.Controls.Add(this.btnDoanhThu);
            this.Controls.Add(this.userControl3_21);
            this.Controls.Add(this.btnThongKeCP);
            this.Controls.Add(this.userControl3_11);
            this.Controls.Add(this.btnSoLanDiTour);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(579, 469);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSoLanDiTour;
        private UserControl3_1 userControl3_11;
        private System.Windows.Forms.Button btnThongKeCP;
        private UserControl3_2 userControl3_21;
        private System.Windows.Forms.Button btnDoanhThu;
        private UserControl3_3 userControl3_31;
        private System.Windows.Forms.Button button1;
    }
}
