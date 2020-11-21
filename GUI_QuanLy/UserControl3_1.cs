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
        private int vt;
        ThongKeBUS bus = new ThongKeBUS();
        private string[] cbb = new string[50];
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
                cbbNhanVien.Items.Add(bus.getMaNV().Rows[i]["MANV"].ToString()+" - "+ bus.getMaNV().Rows[i]["TENNV"].ToString());
                cbb[i] = bus.getMaNV().Rows[i]["MANV"].ToString();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = txtTenNhanVien.Text;
            string tu = txtTu.Text;
            string den = txtDen.Text;
            Bang1.DataSource = bus.ThongKeDLSoLanNhanVienDiTour(tu, den, ma);


            DataTable d = bus.ThongKeSoLanNhanVienDiTour(tu, den, ma);
            if (Bang1.RowCount > 1)
            {
                txtSoLan.Text = d.Rows[0]["TONGSO"].ToString();
            }
        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            vt = cbbNhanVien.SelectedIndex;
            txtTenNhanVien.Text = cbb[vt];
        }
    }
}
