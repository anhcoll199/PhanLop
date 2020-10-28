using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_DOAN : Form
    {
        DoanBUS bus = new DoanBUS();
        public GUI_DOAN()
        {
            InitializeComponent();
        }

        private void GUI_DOAN_Load(object sender, EventArgs e)
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
