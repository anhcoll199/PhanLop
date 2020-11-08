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
        ThongKeDAL dal = new ThongKeDAL();
        public DataTable getMaNV()
        {
            return dal.getNhanVien();
        }
        public DataTable ThongKeDLSoLanNhanVienDiTour(string tu, string den, string ma)
        {
            return dal.ThongKeDLSoLanNhanVienDiTour(tu, den, ma);
        }
        public DataTable ThongKeSoLanNhanVienDiTour(string tu, string den, string ma)
        {
            return dal.ThongKeSoLanNhanVienDiTour(tu, den, ma);
        }
        public DataTable getMaDoanDeThongKeChiPhi(string ma, string tu, string den)
        {
            return dal.getMaDoanDeThongKeChiPhi(ma, tu, den);
        }

        public DataTable ThongKeChiPhiTatCaDoanTheoTour(string ma, string tu, string den)
        {
            return dal.ThongKeChiPhiTatCaDoanTheoTour(ma, tu, den);
        }

        public DataTable ThongKeChiPhiTatCaDoanTheoTourCoMaDoan(string ma, string tu, string den, string doan)
        {
            return dal.ThongKeChiPhiTatCaDoanTheoTourCoMaDoan(ma, tu, den, doan);
        }

        public DataTable ThongKeDoanhThu(string ma, string bd, string kt)
        {
            return dal.ThongKeDoanhThu(ma, bd, kt);
        }

        public DataTable TinhHinhHD(string ma)
        {
            return dal.TinhHinhHD(ma);
        }
    }
}
