using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TH_MVC.DAO;
using TH_MVC.Models;

namespace TH_MVC.BUS
{
    public class SanPhambus
    {
        SanPhamdao pd = new SanPhamdao();
        //public SanPhamMaBuss(ISanPhamMaBus p)
        //{
        //    pd = p;
        //}
        public List<Sanpham> GetSanPham()
        {
            return pd.GetSanpham();
        }
        public List<Sanpham> GetSanPhamLoai(string MaLoai)
        {
            return pd.GetSanPhamLoai(MaLoai);
        }
    }
}