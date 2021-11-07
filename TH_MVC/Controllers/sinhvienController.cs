using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH_MVC.Models;

namespace TH_MVC.Controllers
{
    public class sinhvienController : Controller
    {
        // GET: sinhvien
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            List<Student> ls = new List<Student>();
            var student1 = new Student(1, "Nguyễn Văn A", 19);
            var student2 = new Student(2, "Nguyễn Văn B", 19);
            var student3 = new Student(3, "Nguyễn Văn C", 19);
            var student4 = new Student(4, "Nguyễn Văn D", 19);
            ls.Add(student1);
            ls.Add(student2);
            ls.Add(student3);
            ls.Add(student4);
            return View(ls);
        }
    }
}