using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhamOBJ;

namespace MyPhamDAO
{
    public interface ISanPhamDAO
    {
        Sanpham GetSanpham(string MaSP);
        List<Sanpham> GetSanpham();
        List<Sanpham> GetSanPhamDong(string MaDongSP);
        SanPhamList GetSanpham(int pageIndex, int pageSize, string productName, string madong);
    }
}
