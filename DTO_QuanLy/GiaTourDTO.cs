using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class GiaTourDTO
    {
        private String MaGia, MaTour;
        private float GiaTien;
        private DateTime TGBD, TGKT;

        public GiaTourDTO()
        {

        }
        public GiaTourDTO(String magia, String matour, float gia, DateTime bd, DateTime kt)
        {
            this.MaGia1 = magia;
            this.MaTour1 = matour;
            this.GiaTien1 = gia;
            this.GiaTien1 = gia;
            this.TGBD1 = bd;
            this.TGKT1 = kt;
        }

        public string MaGia1 { get => MaGia; set => MaGia = value; }
        public string MaTour1 { get => MaTour; set => MaTour = value; }
        public float GiaTien1 { get => GiaTien; set => GiaTien = value; }
        public DateTime TGBD1 { get => TGBD; set => TGBD = value; }
        public DateTime TGKT1 { get => TGKT; set => TGKT = value; }
    }
}
