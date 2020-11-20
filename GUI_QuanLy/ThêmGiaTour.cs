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
    public partial class ThêmGiaTour : Form
    {
        TourBUS bus = new TourBUS();
        GiaTourBUS bus1 = new GiaTourBUS();
        public ThêmGiaTour()
        {
            InitializeComponent();
        }

        private void ThêmGiaTour_Load(object sender, EventArgs e)
        {
            txtMatour.Text = UserControl2.ma1;
            txtMatour.Enabled = false;
            dataGridView1.DataSource = bus.XemGiaTheoTour(UserControl2.ma1);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtMagia.Text = row.Cells[0].Value.ToString();
            txtGia.Text = row.Cells[1].Value.ToString();
            txtBd.Text = row.Cells[2].Value.ToString();
            txtKt.Text = row.Cells[3].Value.ToString();
            txtBd.Enabled = false;
            txtKt.Enabled = false;
            txtMagia.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMagia.Enabled = true;
            txtBd.Enabled = true;
            txtKt.Enabled = true;
            txtGia.Text = "";
            txtMagia.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtBd.Text!="" && txtKt.Text != "" && txtMagia.Text!= "" && txtGia.Text!="")
            {
                GiaTourDTO dto = new GiaTourDTO(txtMagia.Text, txtMatour.Text,float.Parse(txtGia.Text),txtBd.Text,txtKt.Text);
                if(bus1.themGia(dto))
                {
                    dataGridView1.DataSource = bus.XemGiaTheoTour(txtMatour.Text);
                    MessageBox.Show("Thêm thành công");
                } 
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }    
                
            }    
            else
            {
                MessageBox.Show("Không thể thêm");
            }
            txtMagia.Text = "";
            txtMatour.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtMagia.Text != "" && txtGia.Text != "")
            {
                GiaTourDTO dto = new GiaTourDTO(txtMagia.Text, txtMatour.Text, float.Parse(txtGia.Text), txtBd.Text, txtKt.Text);
                if (bus1.suaGia(dto))
                {
                    MessageBox.Show("Sửa thành công");
                    dataGridView1.DataSource = bus.XemGiaTheoTour(txtMatour.Text);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }

            }
            txtMatour.Text = "";
            txtMagia.Text = "";
        }
    }
}
