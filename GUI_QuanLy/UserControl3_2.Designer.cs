namespace GUI_QuanLy
{
    partial class UserControl3_2
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
            this.cbbMatour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbbMatour
            // 
            this.cbbMatour.FormattingEnabled = true;
            this.cbbMatour.Location = new System.Drawing.Point(54, 21);
            this.cbbMatour.Name = "cbbMatour";
            this.cbbMatour.Size = new System.Drawing.Size(95, 21);
            this.cbbMatour.TabIndex = 0;
            // 
            // UserControl3_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbMatour);
            this.Name = "UserControl3_2";
            this.Size = new System.Drawing.Size(553, 263);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMatour;
    }
}
