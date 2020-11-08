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
    public partial class UserControl3_4 : UserControl
    {
        TourBUS bus = new TourBUS();
        ThongKeBUS bus1 = new ThongKeBUS();
        public UserControl3_4()
        {
            InitializeComponent();
        }

        private void UserControl3_4_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<bus.getMaTour().Rows.Count; i++)
            {
                comboBox1.Items.Add(bus.getMaTour().Rows[i]["MATOUR"].ToString());
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = comboBox1.Text;

            dataGridView1.DataSource = bus1.TinhHinhHD(ma);
        }
    }
}
