using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_QuanLy
{
    public class DiaDiemDTO
    {
        private String MaDD, TenDD;
        public DiaDiemDTO()
        {

        }
        public DiaDiemDTO(String ma, String ten)
        {
            this.MaDD1 = ma;
            this.TenDD1 = ten;
        }

        public string TenDD1 { get => TenDD; set => TenDD = value; }
        public string MaDD1 { get => MaDD; set => MaDD = value; }
    }
}
