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
        private string getMatour()
        {
            string matour = cbbMatour.SelectedItem.ToString();
            return matour;
        }

        //private string getMaDoan()
        //{
        //    string madoan = cbbMaDoan.SelectedItem.ToString();
        //    return madoan;
        //}

        private void cbbMatour_SelectedIndexChanged(object sender, EventArgs e)
        {
            string matour = getMatour();
            DataTable d = bus.TimKiemTheoMa(matour);
            txtTenTour.Text = d.Rows[0]["TENTOUR"].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = getMatour();
            cbbMaDoan.Items.Add("Tất cả");
            for (int i = 0; i < bus1.getMaDoanDeThongKeChiPhi(ma, dateTimePicker1.Text, dateTimePicker2.Text).Rows.Count; i++)
            {
                cbbMaDoan.Items.Add(bus1.getMaDoanDeThongKeChiPhi(ma, dateTimePicker1.Text, dateTimePicker2.Text).Rows[i]["MADOAN"].ToString());
            }
            dataGridView1.DataSource = bus1.ThongKeChiPhiTatCaDoanTheoTour(getMatour(), dateTimePicker1.Text, dateTimePicker2.Text);
        }

        private void cbbMaDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataTable dtMaDoan = bus1.getMaDoanDeThongKeChiPhi(getMatour(), dateTimePicker1.Text, dateTimePicker2.Text);
            //DataRow row = dtMaDoan.NewRow();
            //row[0] = -1;
            //dtMaDoan.Rows.Add(row);
            //cbbMaDoan.DataSource = dtMaDoan;
            //cbbMaDoan.Text = "-1";
            if(cbbMaDoan.SelectedIndex == 0)
            {
                dataGridView1.DataSource = bus1.ThongKeChiPhiTatCaDoanTheoTour(getMatour(), dateTimePicker1.Text, dateTimePicker2.Text);
            }   
            else
            {
                string madoan = cbbMaDoan.Text;
                dataGridView1.DataSource = bus1.ThongKeChiPhiTatCaDoanTheoTourCoMaDoan(getMatour(), dateTimePicker1.Text, dateTimePicker2.Text,madoan);
            }
        }
    }
}
