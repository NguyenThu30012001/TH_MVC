using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH_MVC.Models;
using TH_MVC.BUS;



namespace mvc.Controllers
{
    public class SanPhamController : Controller
    {
        //ISanPhamMaBus pb = new SanPhamMaBuss();
        SanPhambus pb = new SanPhambus();
        // GET: SanPham
        public ActionResult Index()
        {
            List<Sanpham> lp = pb.GetSanPham();
            return View(lp);
        }
        public JsonResult GetSanPham()
        {
            List<Sanpham> lp =pb.GetSanPham();
            @ViewBag.SoSanPham = lp.Count;
            return Json(new { sp = lp }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetSanPhamLoai(string MaLoai)
        {
            List<Sanpham> lp = pb.GetSanPhamLoai(MaLoai);
            return Json(lp, JsonRequestBehavior.AllowGet);
        }
    }
}