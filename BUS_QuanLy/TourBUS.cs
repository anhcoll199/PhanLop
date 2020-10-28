using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class TourBUS
    {
        TourDAL dal = new TourDAL();
        public DataTable getTour()
        {
            return dal.getTour();
        }
        public DataTable TimKiemTheoMa(string ma)
        {
            return dal.TimKiemTheoMa(ma);
        }
        public bool themTour(TourDTO l)
        {
            return dal.themTour(l);
        }
        public bool xoaTour(String ma)
        {
            return dal.xoaTour(ma);
        }
        public bool suaTour(TourDTO l)
        {
            return dal.suaTour(l);
        }
        public DataTable getMaLoai()
        {
            return dal.getMaLoai();
        }
        public DataTable getMaTour()
        {
            return dal.getMaTour();
        }
        public DataTable getDSDiaDiem(string ma)
        {
            return dal.DSDiaDiem(ma);
        }
        public string XemGiaTheoTour(string ma)
        {
            return dal.XemGiaTheoTour(ma);
        }
    }
}
