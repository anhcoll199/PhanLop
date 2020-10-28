using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class TourDTO
    {
        private String MaTour, Ten, MaTheLoai;
        public TourDTO()
        {

        }
        public TourDTO(String ma, String ten,  String matheloai)
        {
            this.MaTour1 = ma;
            this.Ten1 = ten;
            this.MaTheLoai1 = matheloai;
        }

        public string MaTour1 { get => MaTour; set => MaTour = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string MaTheLoai1 { get => MaTheLoai; set => MaTheLoai = value; }
    }
}
