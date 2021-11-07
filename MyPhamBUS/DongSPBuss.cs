using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhamDAO;
using MyPhamOBJ;

namespace MyPhamBUS
{
    public class DongSPBuss : IDongSPBus
    {
        DongSPDAO ldb = new DongSPDAO();
        public List<DongSP> GetDongSP()
        {
            return ldb.GetDongSP();
        }

    }
}
