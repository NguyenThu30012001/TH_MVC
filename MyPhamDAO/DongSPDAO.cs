using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyPhamOBJ;


namespace MyPhamDAO
{
    public partial class DongSPDAO:IDongSPDAO
    {
        Datahelper dh = new Datahelper();
        public List<DongSP> GetDongSP()
        {
            DataTable dt = dh.GetDataTable("select * from DongSP");
            List<DongSP> List_dong = new List<DongSP>();
            foreach (DataRow r in dt.Rows)
            {
                DongSP fd = new DongSP(r[0].ToString(), r[1].ToString(), r[2].ToString());
                List_dong.Add(fd);
            }
            return List_dong;
        }
        public List<DongSP> ToList(DataTable dt)
        {
            List<DongSP> l = new List<DongSP>();
            foreach (DataRow dr in dt.Rows)
            {
                DongSP s = new DongSP(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                l.Add(s);

            }
            return l;
        }
        //public List<LoaiSP> LayLoaiSP()
        //{
        //    DataTable dt = dh.GetDataTable("Select * from LoaiSP");
        //    return ToList(dt);
        //}
        //public List<LoaiSP> ToList(DataTable dt)
        //{
        //    List<LoaiSP> ll = new List<LoaiSP>();
        //    foreach (DataRow r in dt.Rows)
        //    {
        //        LoaiSP l = new LoaiSP();
        //        l.MaLoai = r[0].ToString();
        //        l.Tenloai = r[1].ToString();
        //        ll.Add(l);
        //    }
        //    return ll;
        //}
    }
    
}
