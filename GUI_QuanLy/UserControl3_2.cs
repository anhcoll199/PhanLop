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
    public partial class UserControl3_2 : UserControl
    {
        TourBUS bus = new TourBUS();
        ThongKeBUS bus1 = new ThongKeBUS();
        public UserControl3_2()
        {
            InitializeComponent();
        }

        private void UserControl3_2_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<bus.getMaTour().Rows.Count; i++)
            {
                cbbMatour.Items.Add(bus.getMaTour().Rows[i]["MATOUR"].ToString());
            }    
        }
        //private string getMatour()
        //{
        //    string matour = "";
        //    if (cbbMatour.Text != null)
        //    {
        //        matour = cbbMatour.SelectedItem.ToString();
        //        return matour;
        //    }
        //    else
        //        return matour;
        //}

        //private string getMaDoan()
        //{
        //    string madoan = cbbMaDoan.SelectedItem.ToString();
        //    return madoan;
        //}

        private void cbbMatour_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matour = cbbMatour.Text;
            DataTable d = bus.TimKiemTheoMa(matour);
            txtTenTour.Text = d.Rows[0]["TENTOUR"].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbbMatour.Text!=null)
            {
                string ma = cbbMatour.Text;
                cbbMaDoan.Items.Add("Tất cả");
                for (int i = 0; i < bus1.getMaDoanDeThongKeChiPhi(ma, dateTimePicker1.Text, dateTimePicker2.Text).Rows.Count; i++)
                {
                    cbbMaDoan.Items.Add(bus1.getMaDoanDeThongKeChiPhi(ma, dateTimePicker1.Text, dateTimePicker2.Text).Rows[i]["MADOAN"].ToString());
                }
                dataGridView1.DataSource = bus1.ThongKeChiPhiTatCaDoanTheoTour(cbbMatour.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            }    
            else
            {
                MessageBox.Show("Ko thể thống kê");
            }    
        }

        private void cbbMaDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbMaDoan.SelectedIndex == 0)
            {
                dataGridView1.DataSource = bus1.ThongKeChiPhiTatCaDoanTheoTour(cbbMatour.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            }   
            else
            {
                string madoan = cbbMaDoan.Text;
                dataGridView1.DataSource = bus1.ThongKeChiPhiTatCaDoanTheoTourCoMaDoan(cbbMatour.Text, dateTimePicker1.Text, dateTimePicker2.Text,madoan);
            }
        }
    }
}
