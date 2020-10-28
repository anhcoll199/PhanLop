using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_DiaDiem
    {
        DiaDiemDAL dalDiemDiem = new DiaDiemDAL();

        public DataTable getDiaDiem()
        {
            return dalDiemDiem.getDiaDiem();
        }
        public bool themDiaDiem(DiaDiemDTO dd)
        {
            return dalDiemDiem.themDiaDiem(dd);
        }
        public bool xoaDiaDiem(String ma)
        {
            return dalDiemDiem.xoaThanhVien(ma);
        }
        public bool suaDiaDiem(DiaDiemDTO dd)
        {
            return dalDiemDiem.suaDiemDia(dd);
        }
    }
}
