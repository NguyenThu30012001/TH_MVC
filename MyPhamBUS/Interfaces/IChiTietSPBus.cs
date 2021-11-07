using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhamOBJ;

namespace MyPhamBUS
{
    public interface IChiTietSPBus
    {
        Sanpham GetSanpham(string MaSP);

    }
}
