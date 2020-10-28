using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;
using System.Runtime.InteropServices;

namespace GUI_QuanLy
{
    public partial class UserControl3_1 : UserControl
    {
        ThongKeBUS bus = new ThongKeBUS();
        public UserControl3_1()
        {
            InitializeComponent();
            
        }

        private void UserControl3_1_Load(object sender, EventArgs e)
        {
            txtTenNhanVien.Enabled = false;
            txtSoLan.Enabled = false;
            for(int i=0; i<bus.getMaNV().Rows.Count; i++)
            {
                cbbNhanVien.Items.Add(bus.getMaNV().Rows[i]["MANV"].ToString());
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = cbbNhanVien.Text;
            string tu = txtTu.Text;
            string den = txtDen.Text;
            Bang1.DataSource = bus.ThongKeDLSoLanNhanVienDiTour(tu, den, ma);


            DataTable d = bus.ThongKeSoLanNhanVienDiTour(tu, den, ma);
            txtSoLan.Text = d.Rows[0]["TONGSO"].ToString();
            txtTenNhanVien.Text = d.Rows[0]["TENNV"].ToString(); 
        }
    }
}
