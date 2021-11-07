using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPhamBUS;
using MyPhamOBJ;

namespace DOANMVC.Controllers
{
    [Route("SanPham")]
    public class SanPhamController : Controller
    {
        // GET: SanPham
        
        //ISanPhamMaBus pb = new SanPhamMaBuss();
        SanPhamMaBuss pb = new SanPhamMaBuss();
        // GET: SanPham
        public ActionResult Index()
        {
            List<Sanpham> lp = pb.GetSanpham();
            return View(lp);
        }

        public ActionResult TrangDiem()
        {
            return View();
        }
       
        [Route("/getSanPham")]
        public JsonResult GetSanPham()
        {
            List<Sanpham> lp = pb.GetSanpham();
            @ViewBag.SoSanPham = lp.Count;
            return Json(new { sp = lp }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetSanPhamDong(string MaDongSP)
        {
            List<Sanpham> lp = pb.GetSanPhamDong(MaDongSP);
            return Json(lp, JsonRequestBehavior.AllowGet);
        }
    }
}