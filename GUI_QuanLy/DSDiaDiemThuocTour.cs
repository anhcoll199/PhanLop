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
    public partial class DSDiaDiemThuocTour : Form
    {
        TourBUS bus = new TourBUS();
        public DSDiaDiemThuocTour()
        {
            InitializeComponent();
        }

        private void DSDiaDiemThuocTour_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < bus.getMaTour().Rows.Count; i++)
            {
                cbb1.Items.Add(bus.getMaTour().Rows[i]["MATOUR"].ToString());
            }
        }

        private void cbb1_TextChanged(object sender, EventArgs e)
        {
            txt1.Text = cbb1.Text;
            Bang.DataSource = bus.getDSDiaDiem(txt1.Text);
        }
    }
}
