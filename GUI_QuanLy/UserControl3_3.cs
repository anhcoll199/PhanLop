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

namespace GUI_QuanLy
{
    public partial class UserControl3_3 : UserControl
    {
        ThongKeBUS bus = new ThongKeBUS();
        TourBUS bus1 = new TourBUS();
        public UserControl3_3()
        {
            InitializeComponent();
        }

        private void UserControl3_3_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<bus1.getMaTour().Rows.Count; i++)
            {
                comboBox1.Items.Add(bus1.getMaTour().Rows[i]["MATOUR"].ToString());
            }    
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string ma = comboBox1.Text;
            string bd = dateTimePicker1.Text;
            string kt = dateTimePicker2.Text;

            if(ma != "" && bd != "" && kt != "")
            {
                dataGridView1.DataSource = bus.ThongKeDoanhThu(ma, bd, kt);
                int tong = 0;
                for(int i = 0; i<dataGridView1.Rows.Count-1; i++)
                {
                    tong = tong + Int32.Parse(dataGridView1.Rows[i].Cells["DOANHTHU"].Value.ToString());
                }
                textBox1.Text = tong.ToString();
            }    
        }
    }
}
