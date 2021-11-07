using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPhamOBJ
{
    public class Sanpham
    {
        public string MaSP { get; set; }
        public string TenSp { get; set; }
        public string MaDongSP { get; set; }
        public string DungLuong { get; set; }
        public string MaTH { get; set; }
        public string MoTa { get; set; }
        public string Anh { get; set; }
        public string MauSac { get; set; }
        public string MuiHuong { get; set; }
        public string KieuDang { get; set; }
        public Sanpham(string masp, string tensp, string madong, 
                       string dungluong,string math,string mota,
                       string anh, string mausac, string muihuong,
                       string kieudang)
        {
            this.MaSP = masp;
            this.TenSp = tensp;
            this.MaDongSP = madong;
            this.DungLuong = dungluong;
            this.MaTH = math;
            this.MoTa = mota;
            this.Anh = anh;
            this.MauSac = mausac;
            this.MuiHuong = muihuong;
            this.KieuDang = kieudang;
        }

    }
}