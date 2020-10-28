using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;
using System.Text.RegularExpressions;

namespace GUI_QuanLy
{
    public partial class GUI_DiaDiem : Form
    {
        BUS_DiaDiem bus = new BUS_DiaDiem();

        public GUI_DiaDiem()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "" && txtTen.Text != "")
            {
                // Tạo DTo
                DiaDiemDTO dto = new DiaDiemDTO(txtMa.Text, txtTen.Text); 

                // Them
                if (bus.themDiaDiem(dto))
                {
                    MessageBox.Show("Thêm thành công");
                    Bang_DiemDiem.DataSource = bus.getDiaDiem(); // refresh datagridview
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

        private void GUI_ThanhVien_Load(object sender, EventArgs e)
        {
            Bang_DiemDiem.DataSource = bus.getDiaDiem(); // get thanh vien
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Bang_DiemDiem.SelectedRows.Count > 0)
            {
                if (txtMa.Text != "" && txtTen.Text != "")
                {
                    if (ValadateTen(txtTen.Text))
                    {
                        MessageBox.Show("Tên tác giả tại sao lại chứa kí tự lạ hả!!!", "Thông báo");
                        txtTen.Text = "";
                        txtTen.Focus();
                    }
                    else
                    if (ValadateTen(txtMa.Text))
                    {
                        MessageBox.Show("Mã đọc giả tại sao lại chứa kí tự lạ hả!!!", "Thông báo");
                        txtMa.Text = "";
                        txtMa.Focus();
                    }
                    else
                    {
                        DataGridViewRow row = Bang_DiemDiem.SelectedRows[0];
                        string ma = row.Cells[0].Value.ToString();

                        DiaDiemDTO sDTO = new DiaDiemDTO(ma, txtTen.Text);

                        // Sửa
                        if (bus.suaDiaDiem(sDTO))
                        {
                            MessageBox.Show("Sửa thành công");
                            Bang_DiemDiem.DataSource = bus.getDiaDiem(); // refresh datagridview
                        }
                        else
                        {
                            MessageBox.Show("Sửa ko thành công");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn tác giả muốn sửa");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Bang_DiemDiem.SelectedRows.Count > 0)
            {
                DataGridViewRow row = Bang_DiemDiem.SelectedRows[0];
                string ma = row.Cells[0].Value.ToString();

                if (bus.xoaDiaDiem(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    Bang_DiemDiem.DataSource = bus.getDiaDiem(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn dia diem muốn xóa");
            }
        }

        private void Bang_DiemDiem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = Bang_DiemDiem.SelectedRows[0];
            txtMa.Text = row.Cells[0].Value.ToString();
            txtTen.Text = row.Cells[1].Value.ToString();
        }
        private bool ValadateTen(string ten)
        {
            var regexItem = new Regex("[!@#$%^&*(){};',.?/<>[=+_-]");
            if (regexItem.IsMatch(ten))
                return true;
            else
                return false;
        }
    }
}
