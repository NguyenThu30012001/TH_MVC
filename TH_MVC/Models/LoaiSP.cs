using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TH_MVC.Models
{
    public class LoaiSP
    {
        public string MaLoai { get; set; }
        public string Tenloai { get; set; }
        public LoaiSP(string maloai, string tenloai)
        {
            this.MaLoai = maloai;
            this.Tenloai = tenloai;

        }
    }
}