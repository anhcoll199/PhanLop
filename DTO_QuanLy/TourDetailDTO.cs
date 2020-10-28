using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class TourDetailDTO
    {
        private String MaTour, MaDiaDiem;
        public TourDetailDTO()
        {

        }
        public TourDetailDTO(String matour,  String madd)
        {
            this.MaTour1 = matour;
            this.MaDiaDiem1 = madd;
        }

        public string MaTour1 { get => MaTour; set => MaTour = value; }
        public string MaDiaDiem1 { get => MaDiaDiem; set => MaDiaDiem = value; }
    }
}
