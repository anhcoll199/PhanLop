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
            this.button4 = new System.Windows.Forms.Button();
            this.userControl3_11 = new GUI_QuanLy.UserControl3_1();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl3_21 = new GUI_QuanLy.UserControl3_2();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Số lần đi tour của nhân viên trong thời gian";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // userControl3_11
            // 
            this.userControl3_11.Location = new System.Drawing.Point(3, 66);
            this.userControl3_11.Name = "userControl3_11";
            this.userControl3_11.Size = new System.Drawing.Size(580, 289);
            this.userControl3_11.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thống kê chi phí tour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl3_21
            // 
            this.userControl3_21.Location = new System.Drawing.Point(14, 66);
            this.userControl3_21.Name = "userControl3_21";
            this.userControl3_21.Size = new System.Drawing.Size(553, 263);
            this.userControl3_21.TabIndex = 9;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl3_21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControl3_11);
            this.Controls.Add(this.button4);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(579, 351);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private UserControl3_1 userControl3_11;
        private System.Windows.Forms.Button button1;
        private UserControl3_2 userControl3_21;
    }
}
