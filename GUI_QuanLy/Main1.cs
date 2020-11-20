using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
        }

        private void quảnLýTourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userControl3_41.Hide();
            userControl3_31.Hide();
            userControl3_21.Hide();
            userControl11.Show();
            userControl21.Hide();
            userControl3_11.Hide();
        }

        private void quảnLýĐoànKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl3_41.Hide();
            userControl3_31.Hide();
            userControl3_21.Hide();
            userControl11.Hide();
            userControl21.Show();
            userControl3_11.Hide();
        }

        private void Main1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl3_11.Hide();
            userControl3_21.Hide();
            userControl3_31.Hide();
            userControl3_41.Hide();
        }

        private void thốngKêChiPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl3_41.Hide();
            userControl3_31.Hide();
            userControl3_21.Show();
            userControl11.Hide();
            userControl21.Hide();
            userControl3_11.Hide();
        }

        private void sốLầnĐiTourCủaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl3_41.Hide();
            userControl3_31.Hide();
            userControl3_21.Hide();
            userControl11.Hide();
            userControl21.Hide();
            userControl3_11.Show();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl3_31.Show();
            userControl11.Hide();
            userControl21.Hide();
            userControl3_11.Hide();
            userControl3_21.Hide();
            userControl3_41.Hide();
        }

        private void tìnhHìnhHoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl3_41.Show();
            userControl11.Hide();
            userControl21.Hide();
            userControl3_11.Hide();
            userControl3_21.Hide();
            userControl3_31.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
