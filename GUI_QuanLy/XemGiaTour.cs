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
    public partial class XemGiaTour : Form
    {
        TourBUS bus = new TourBUS();
        public XemGiaTour()
        {
            InitializeComponent();
        }

        private void XemGiaTour_Load(object sender, EventArgs e)
        {
           // string matour;
           //// matour = UserControl2.ma1;

           // string gia = bus.XemGiaTheoTour(matour);

           // txtGia.Text = gia.ToString();
        }
    }
}
