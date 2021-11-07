using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPhamOBJ
{
    public class DongSP
    {
        public string MaDongSP { get; set; }
        public string TenDongSP { get; set; }
        public string MaTH { get; set; }
        public DongSP(string madong, string tendong,string math)
        {
            this.MaDongSP = madong;
            this.TenDongSP = tendong;
            this.MaTH = math;

        }
    }
}