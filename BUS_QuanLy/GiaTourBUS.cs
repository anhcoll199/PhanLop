using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class GiaTourBUS
    {
        GiaTourDAL dal = new GiaTourDAL();
        public DataTable getGiaTour()
        {
            return dal.getGia();
        }
        public bool themGia(GiaTourDTO l)
        {
            return dal.themGia(l);
        }
        public bool xoaGia(String ma)
        {
            return dal.xoaGia(ma);
        }
        public bool suaGia(GiaTourDTO l)
        {
            return dal.suaGia(l);
        }
        public DataTable getMaTour()
        {
            return dal.getMaTour();
        }
    }
}
