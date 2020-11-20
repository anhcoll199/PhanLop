using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class TourDetailDTO
    {
        private String MaTour, MaDiaDiem;
        private int thutu;
        public TourDetailDTO()
        {

        }
        public TourDetailDTO(String matour,  String madd, int tt)
        {
            this.MaTour1 = matour;
            this.MaDiaDiem1 = madd;
            this.thutu = tt;
        }

        public string MaTour1 { get => MaTour; set => MaTour = value; }
        public string MaDiaDiem1 { get => MaDiaDiem; set => MaDiaDiem = value; }
        public int thutu1 { get => thutu; set => thutu = value; }

    }
}
