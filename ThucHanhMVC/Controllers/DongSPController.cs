using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPhamBUS;
using MyPhamOBJ;

namespace ThucHanhMVC.Controllers
{
    public class DongSPController : Controller
    {
        // GET: DongSP
        public ActionResult Index()
        {
            return View();
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