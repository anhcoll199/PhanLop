using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class NhanVienDTO
    {
        private string MaNhanVien, TenNhanVien;

        public NhanVienDTO() { }
        public NhanVienDTO(string ma, string ten)
        {
            this.MaNhanVien = ma;
            this.TenNhanVien = ten;
        }

        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public string TenNhanVien1 { get => TenNhanVien; set => TenNhanVien = value; }
    }
}
