using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class LoaiTourBUS
    {
        LoaiTourDAL dal = new LoaiTourDAL();
        public DataTable getLoaiTour()
        {
            return dal.getLoaiTour();
        }
        public bool themLoai(LoaiTourDTO l)
        {
            return dal.themLoai(l);
        }
        public bool xoaLoai(String ma)
        {
            return dal.xoaLoai(ma);
        }
        public bool suaLoai(LoaiTourDTO l)
        {
            return dal.suaLoia(l);
        }
    }
}
