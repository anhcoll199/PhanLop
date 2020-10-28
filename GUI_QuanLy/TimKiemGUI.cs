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
    public partial class TimKiemGUI : Form
    {
        int luachon;
        KhachBUS bus1 = new KhachBUS();
        TourBUS bus3 = new TourBUS();
        DoanBUS bus2 = new DoanBUS();
        public TimKiemGUI()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            luachon = cbb1.SelectedIndex;
            string text = txt1.Text;
            if (text != "")
            {
                if(luachon==0)
                {
                    BangTimKiem.DataSource = bus1.TimKiemTheoMaKhach(text);
                }
                else
                if(luachon==1)
                {
                    BangTimKiem.DataSource = bus2.TimKiemTheoMa(text);
                }
                else
                if (luachon == 2)
                {
                    BangTimKiem.DataSource = bus3.TimKiemTheoMa(text);
                }
            }   
            else
            {
                MessageBox.Show("Vui long nhap ma can tim");
            }    
        }
    }
}
