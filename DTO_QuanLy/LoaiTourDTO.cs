using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class LoaiTourDTO
    {
        String MaLoai, TenLoai;
        public LoaiTourDTO()
        {

        }
        public LoaiTourDTO(String ma, String ten)
        {
            this.MaLoai1 = ma;
            this.TenLoai1 = ten;
        }

        public string MaLoai1 { get => MaLoai; set => MaLoai = value; }
        public string TenLoai1 { get => TenLoai; set => TenLoai = value; }
    }
}
