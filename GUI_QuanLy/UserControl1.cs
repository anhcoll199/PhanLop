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
    public partial class UserControl1 : UserControl
    {
        DoanBUS bus = new DoanBUS();
        TourBUS bus1 = new TourBUS();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            BangDoan.DataSource = bus.getDoan();
            for(int i=0; i<bus1.getMaTour().Rows.Count; i++)
            {
                cbbMaTour.Items.Add(bus1.getMaTour().Rows[i]["MATOUR"].ToString());
            }    
        }

        private void btnDSKhach_Click(object sender, EventArgs e)
        {
            DSKhachThuocDoan_GUI g = new DSKhachThuocDoan_GUI();
            g.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaDoan.Text != "" && txtBD.Text != "" && txtKT.Text != "" && cbbMaTour.Text != "")
            {
                DoanDTO DTO = new DoanDTO(txtMaDoan.Text, txtBD.Text, txtKT.Text, cbbMaTour.Text);
                if (bus.themDoan(DTO))
                {
                    MessageBox.Show("Thêm thành công");
                    BangDoan.DataSource = bus.getDoan();
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
            if (BangDoan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = BangDoan.SelectedRows[0];
                string ma = row.Cells[0].Value.ToString();

                if (bus.xoaDoan(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    BangDoan.DataSource = bus.getDoan(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn 1 đoàn muốn xóa");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(BangDoan.SelectedRows.Count>0)
            {
                if (txtMaDoan.Text != "" && txtBD.Text != "" && txtKT.Text != "" && cbbMaTour.Text != "")
                {
                    DataGridViewRow row = BangDoan.SelectedRows[0];
                    string ma = txtMaDoan.Text;

                    DoanDTO dto = new DoanDTO(ma, txtBD.Text, txtKT.Text, cbbMaTour.Text);
                    if (bus.suaDoan(dto))
                    {
                        MessageBox.Show("Sửa thành công");
                        BangDoan.DataSource = bus.getDoan();
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
                }    
            }  
            else
            {
                MessageBox.Show("Chọn 1 dòng muốn sửa");
            }    
        }

        private void BangDoan_Click(object sender, EventArgs e)
        {
            int VT = BangDoan.CurrentCell.RowIndex;
            txtMaDoan.Text = BangDoan.Rows[VT].Cells[0].Value.ToString();
            txtBD.Text = BangDoan.Rows[VT].Cells[1].Value.ToString();
            txtKT.Text = BangDoan.Rows[VT].Cells[2].Value.ToString();
            cbbMaTour.Text = BangDoan.Rows[VT].Cells[3].Value.ToString();

            txtMaDoan.Enabled = false;
        }
    }
}
