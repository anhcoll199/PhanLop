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
    public partial class GiaTourGUI : Form
    {
        GiaTourBUS bus = new GiaTourBUS();
        public GiaTourGUI()
        {
            InitializeComponent();
        }

        private void GiaTourGUI_Load(object sender, EventArgs e)
        {
            BangGia.DataSource = bus.getGiaTour();
            for(int i=0; i< bus.getMaTour().Rows.Count; i++)
            {
                cbbMaTour.Items.Add(bus.getMaTour().Rows[i]["MATOUR"].ToString());
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbMaTour.GetItemText(cbbMaTour.SelectedItem) != "" && txtBD.Text != "" && txtMa.Text != "" && txtGia.Text != "" && txtKT.Text !="")
            {
                String maTour = cbbMaTour.GetItemText(cbbMaTour.SelectedItem);
                GiaTourDTO DTO = new GiaTourDTO(txtMa.Text, maTour, float.Parse(txtGia.Text), txtBD.Value, txtKT.Value);
                if (bus.themGia(DTO))
                {
                    MessageBox.Show("Thêm thành công");
                    BangGia.DataSource = bus.getGiaTour(); 
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BangGia.SelectedRows.Count > 0)
            {
                DataGridViewRow row = BangGia.SelectedRows[0];
                string ma = row.Cells[0].Value.ToString();

                if (bus.xoaGia(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    BangGia.DataSource = bus.getGiaTour(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn gia muốn xóa");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void BangGia_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = BangGia.SelectedRows[0];
            txtMa.Text = row.Cells[0].Value.ToString();
            txtGia.Text = row.Cells[1].Value.ToString();
            txtBD.Text = row.Cells[2].Value.ToString();
            txtKT.Text = row.Cells[3].Value.ToString();
            cbbMaTour.Text = row.Cells[4].Value.ToString();
        }
    }
}
