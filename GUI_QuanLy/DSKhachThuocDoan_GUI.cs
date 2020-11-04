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
    public partial class DSKhachThuocDoan_GUI : Form
    {
        DoanBUS bus = new DoanBUS();
        public DSKhachThuocDoan_GUI()
        {
            InitializeComponent();
        }

        private void DSKhachThuocDoan_GUI_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < bus.getMaDoan().Rows.Count; i++)
            {
                cbb1.Items.Add(bus.getMaDoan().Rows[i]["MADOAN"].ToString());
            }
        }

        private void cbb1_TextChanged(object sender, EventArgs e)
        {
            //txt1.Text = cbb1.Text;
            Bang.DataSource = bus.getDSKhach(cbb1.Text);
        }
    }
}
