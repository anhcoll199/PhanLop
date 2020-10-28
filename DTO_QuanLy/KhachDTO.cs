using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class KhachDTO
    {
        private string MaKhach, HoTen, CMND, GioiTinh, SDT;

        public KhachDTO() { }

        public KhachDTO(string ma, string ten, string cm, string gt, string sdt)
        {
            this.MaKhach1 = ma;
            this.HoTen1 = ten;
            this.CMND1 = cm;
            this.GioiTinh1 = gt;
            this.SDT1 = sdt;
        }

        public string MaKhach1 { get => MaKhach; set => MaKhach = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
    }
}
