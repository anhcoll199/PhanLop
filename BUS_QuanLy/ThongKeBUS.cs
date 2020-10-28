using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLy;

namespace BUS_QuanLy
{
    public class ThongKeBUS
    {
        ThongKeDAL bus = new ThongKeDAL();
        public DataTable getMaNV()
        {
            return bus.getNhanVien();
        }
        public DataTable ThongKeDLSoLanNhanVienDiTour(string tu, string den, string ma)
        {
            return bus.ThongKeDLSoLanNhanVienDiTour(tu, den, ma);
        }
        public DataTable ThongKeSoLanNhanVienDiTour(string tu, string den, string ma)
        {
            return bus.ThongKeSoLanNhanVienDiTour(tu, den, ma);
        }
    }
}
