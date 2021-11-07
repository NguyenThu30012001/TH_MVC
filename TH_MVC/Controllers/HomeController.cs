using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TH_MVC.Controllers
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
        public PartialViewResult GetMenu()
        {
            var language = 0;
            if (language == 1)
                return PartialView("_Menu");
            else
                return PartialView("_MenuView");
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public JsonResult GetCategory()
        //{
        //    List<LoaiSP> lct = categoryBus.GetCategory();
        //    return Json(lct, JsonRequestBehavior.AllowGet);
        //}
    }
}