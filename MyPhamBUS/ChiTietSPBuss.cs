using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhamDAO;
using MyPhamOBJ;

namespace MyPhamBUS
{
    public class ChiTietSPBuss:IChiTietSPBus
    {
        ISanPhamDAO pd = new SanPhamDAO();
        public Sanpham GetSanpham(string MaSP)
        {
            return pd.GetSanpham(MaSP);
        }
    }
}
