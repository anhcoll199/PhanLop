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
using System.Text.RegularExpressions;

namespace GUI_QuanLy
{
    public partial class UserControl2 : UserControl
    {
        TourBUS bus = new TourBUS();
        public static string ma1 = "";
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            BangTour.DataSource = bus.getTour();

            for (int i = 0; i < bus.getMaLoai().Rows.Count; i++)
            {
                cbbLoai.Items.Add(bus.getMaLoai().Rows[i]["MALOAI"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbLoai.GetItemText(cbbLoai.SelectedItem) != ""  && txtMa.Text != "" && txtTen.Text != "")
            {
                String maLoai = cbbLoai.GetItemText(cbbLoai.SelectedItem);
                TourDTO DTO = new TourDTO(txtMa.Text, txtTen.Text, maLoai);
                if (bus.themTour(DTO))
                {
                    MessageBox.Show("Thêm thành công");
                    BangTour.DataSource = bus.getTour(); // refresh datagridview
                    ChiTietTour g = new ChiTietTour();
                    g.ShowDialog();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BangTour_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = BangTour.SelectedRows[0];
            txtMa.Text = row.Cells[0].Value.ToString();
            txtTen.Text = row.Cells[1].Value.ToString();
            cbbLoai.Text = row.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (BangTour.SelectedRows.Count > 0)
            {
                DataGridViewRow row = BangTour.SelectedRows[0];
                string ma = row.Cells[0].Value.ToString();

                if (bus.xoaTour(ma))
                {
                    MessageBox.Show("Xóa thành công");
                    BangTour.DataSource = bus.getTour(); // refresh datagridview
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (BangTour.SelectedRows.Count > 0)
            {
                if (txtMa.Text != "" && txtTen.Text != ""  && cbbLoai.Text != "")
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
                        DataGridViewRow row = BangTour.SelectedRows[0];
                        string ma = row.Cells[0].Value.ToString();

                        TourDTO sDTO = new TourDTO(ma, txtTen.Text, cbbLoai.Text);

                        // Sửa
                        if (bus.suaTour(sDTO))
                        {
                            MessageBox.Show("Sửa thành công");
                            BangTour.DataSource = bus.getTour(); // refresh datagridview
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
        private bool ValadateTen(string ten)
        {
            var regexItem = new Regex("[!@#$%^&*(){};',.?/<>[=+_-]");
            if (regexItem.IsMatch(ten))
                return true;
            else
                return false;
        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            DSDiaDiemThuocTour gui = new DSDiaDiemThuocTour();
            gui.ShowDialog();
        }

        private void btnXemGia_Click(object sender, EventArgs e)
        {
            if (BangTour.SelectedRows.Count > 0)
            {
                DataGridViewRow row = BangTour.SelectedRows[0];
                ma1 = row.Cells[0].Value.ToString();

                XemGiaTour g = new XemGiaTour();
                g.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn tour muốn xem giá");
            }
        }
    }
}
