using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhamDAO;
using MyPhamOBJ;


namespace MyPhamBUS
{
    public interface ISanPhamMaBus
    {
        List<Sanpham> GetSanpham();
        List<Sanpham> GetSanPhamDong(string MaDongSP);

        SanPhamList GetSanpham(int pageIndex, int pagesize, string productname, string madong);
    }
}
