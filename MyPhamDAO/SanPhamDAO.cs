using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPhamOBJ;
using System.Data;
using ToPage;
using System.Data.SqlClient;

namespace MyPhamDAO
{
    public class SanPhamDAO: ISanPhamDAO
    {
        Datahelper dh = new Datahelper();
        public List<Sanpham> GetSanpham()
        {
            DataTable dt = dh.GetDataTable("Select*from SanPham");
            return ToList(dt);
        }

        public List<Sanpham> ToList(DataTable dt)
        {
            List<Sanpham> l = new List<Sanpham>();
            foreach (DataRow dr in dt.Rows)
            {
                Sanpham s = new Sanpham(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                    dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), 
                    dr[9].ToString());
                l.Add(s);

            }
            return l;
        }
        public List<Sanpham> GetSanPhamDong(string MaDongSP)
        {
            string sqlselect;
            if (MaDongSP != "")
            {
                sqlselect = "select*from SanPham where MaDongSP ='" + MaDongSP + "'";

            }
            else
                sqlselect = "select*from SanPham";
            DataTable dt = dh.GetDataTable(sqlselect);
            return ToList(dt);
        }


        public SanPhamList GetSanpham(int pageIndex, int pageSize, string productName, string madong)
        {
            SanPhamList sql = new SanPhamList();
            List<Sanpham> l = new List<Sanpham>();
            SqlDataReader dr = dh.StoreReaders("GetSanphams", pageIndex, pageSize, productName, madong);
            while (dr.Read())
            {
                Sanpham s = new Sanpham(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                    dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                l.Add(s);
            }
            sql.Sanphams = l;
            dr.NextResult();
            while (dr.Read())
            {
                sql.totalCount = dr["totalCount"].ToString();
            }
            return sql;

        }
        public Sanpham GetSanpham(string MaSP)
        {
            DataTable dt = dh.GetDataTable("select*from SanPham where MaSP='" + MaSP + "'");
            //Sanpham sp = new Sanpham();
            if (dt.Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                DataRow dr = dt.Rows[0];
                Sanpham s = new Sanpham(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),
                     dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                return s;
            }
        }
    }

}
