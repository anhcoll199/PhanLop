using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DoanDTO
    {
        private String MaDoan, MaTour;
        private string NgayBD, NgayKT;

        public DoanDTO()
        {

        }
        public DoanDTO(String madoan, string bd, string kt, String matour)
        {
            this.MaDoan1 = madoan;
            this.NgayBD1 = bd;
            this.NgayKT1 = kt;
            this.MaTour1 = matour;
        }

        public string MaDoan1 { get => MaDoan; set => MaDoan = value; }
        public string MaTour1 { get => MaTour; set => MaTour = value; }
        public string NgayBD1 { get => NgayBD; set => NgayBD = value; }
        public string NgayKT1 { get => NgayKT; set => NgayKT = value; }
    }
}
