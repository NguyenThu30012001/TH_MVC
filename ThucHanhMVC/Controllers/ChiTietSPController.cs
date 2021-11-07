using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPhamBUS;
using MyPhamOBJ;
namespace ThucHanhMVC.Controllers
{
    public class ChiTietSPController : Controller
    {
        
        // GET: ChiTietSP
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult GetSanPham(string MaSP)
        {
            ChiTietSPBuss pb = new ChiTietSPBuss();
            Sanpham p = pb.GetSanpham(MaSP);
            return Json(p, JsonRequestBehavior.AllowGet);
        }
    }
}