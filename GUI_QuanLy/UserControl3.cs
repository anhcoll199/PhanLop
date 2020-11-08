using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl3_11.Show();
            userControl3_21.Hide();
            userControl3_31.Hide();
            userControl3_41.Hide();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            userControl3_11.Hide();
            userControl3_21.Hide();
            userControl3_31.Hide();
            userControl3_41.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl3_21.Show();
            userControl3_11.Hide();
            userControl3_31.Hide();
            userControl3_41.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl3_21.Hide();
            userControl3_11.Hide();
            userControl3_31.Show();
            userControl3_41.Hide();
        }

        private void userControl3_31_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            userControl3_11.Hide();
            userControl3_21.Hide();
            userControl3_31.Hide();
            userControl3_41.Show();
        }
    }
}
