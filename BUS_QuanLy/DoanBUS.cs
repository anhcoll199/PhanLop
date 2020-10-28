using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_QuanLy;
using DAL_QuanLy;
using System.Data;

namespace BUS_QuanLy
{
    public class DoanBUS
    {
        DoanDAL dalDoan = new DoanDAL();

        public DataTable getDoan()
        {
            return dalDoan.getDoan();
        }
        public DataTable TimKiemTheoMa(string ma)
        {
            return dalDoan.TimKiemTheoMa(ma);
        }
        public DataTable getMaDoan()
        {
            return dalDoan.getMaDoan();
        }
        public DataTable getDSKhach(string ma)
        {
            return dalDoan.DSKhach(ma);
        }
    }
}
