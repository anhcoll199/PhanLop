using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class UserControl1 : UserControl
    {
        DoanBUS bus = new DoanBUS();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            BangDoan.DataSource = bus.getDoan();
        }

        private void btnDSKhach_Click(object sender, EventArgs e)
        {
            DSKhachThuocDoan_GUI g = new DSKhachThuocDoan_GUI();
            g.ShowDialog();
        }
    }
}
