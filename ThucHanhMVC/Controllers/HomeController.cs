using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPhamBUS;
using MyPhamOBJ;

namespace ThucHanhMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public PartialViewResult GetMenu()
        {
            return PartialView("Menu");
        }
        
        SanPhamMaBuss sb = new SanPhamMaBuss();
        DongSPBuss lb = new DongSPBuss();
        [HttpGet]
        public JsonResult GetSanPham(string MaDongSP)
        {
            List<Sanpham> lsp = sb.GetSanPhamDong(MaDongSP);
            return Json(lsp, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public JsonResult GetDongSP()
        {
            DongSPBuss bl = new DongSPBuss();
            List<DongSP> l = bl.GetDongSP();
            return Json(l, JsonRequestBehavior.AllowGet);
        }
       
        
    }
}