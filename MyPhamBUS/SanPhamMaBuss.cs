using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhamDAO;
using MyPhamOBJ;
namespace MyPhamBUS
{
    public class SanPhamMaBuss:ISanPhamMaBus
    {
        ISanPhamDAO pd = new SanPhamDAO();
        //public SanPhamMaBuss(ISanPhamMaBus p)
        //{
        //    pd = p;
        //}
        public List<Sanpham> GetSanpham()
        {
            return pd.GetSanpham();
        }
        public List<Sanpham> GetSanPhamDong(string MaDongSP)
        {
            return pd.GetSanPhamDong(MaDongSP);
        }
        public SanPhamList GetSanpham(int pageIndex, int pagesize, string productname, string madong)
        {
            return pd.GetSanpham(pageIndex, pagesize, productname, madong);
        }
    }
}
