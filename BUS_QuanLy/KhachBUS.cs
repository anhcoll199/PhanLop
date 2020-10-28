using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class KhachBUS
    {
        KhachDAL dal = new KhachDAL();
        public DataTable TimKiemTheoMaKhach(string ma)
        {
            return dal.TimKiemTheoMaKhach(ma);
        }
    }
}
