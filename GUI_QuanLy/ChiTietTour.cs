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
    public partial class ChiTietTour : Form
    {
        private int vtRowTable1;
        private int vtRowTable2;
        private string machontubang1;

        BUS_DiaDiem bus = new BUS_DiaDiem();
        public ChiTietTour()
        {
            InitializeComponent();
        }

        private void ChiTietTour_Load(object sender, EventArgs e)
        {
            BangDiaDiem.DataSource = bus.getDiaDiem();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (BangDiaDiem.SelectedRows.Count>0)
            {                
                if(dataGridView2.RowCount>1)
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        string val = row.Cells[0].Value.ToString();
                        if (val.Equals(machontubang1))
                        {
                            flag = 1;
                            break;
                        }
                        else
                            flag = 0;
                    }
                }
                if (flag == 0)
                {
                    int vt = vtRowTable1;
                    dataGridView2.Rows.Add(BangDiaDiem.Rows[vt].Cells[0].Value.ToString(), BangDiaDiem.Rows[vt].Cells[1].Value.ToString());

                    BangDiaDiem.Rows[vt].ReadOnly = true;
                    BangDiaDiem.Rows[vt].DefaultCellStyle.BackColor = Color.Gray;
                    BangDiaDiem.Rows[vt].DefaultCellStyle.ForeColor = Color.White;
                    BangDiaDiem.Rows[vt].Selected = false;
                    BangDiaDiem.ClearSelection();
                }
                else
                    MessageBox.Show("Địa điểm này đã được chọn");
            }
        }

        private void BangDiaDiem_Click(object sender, EventArgs e)
        {
            int VT = BangDiaDiem.CurrentRow.Index;
            vtRowTable1 = VT;
            machontubang1 = BangDiaDiem.CurrentCell.Value.ToString();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            int VT = BangDiaDiem.CurrentRow.Index;
            vtRowTable2 = VT;
        }

        private void txtBack_Click(object sender, EventArgs e)
        {
            if(dataGridView2.SelectedRows.Count>0)
            {
                int vt = vtRowTable2;
                dataGridView2.Rows.RemoveAt(vt);
            }
        }

    }
}
