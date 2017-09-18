using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Colossious_Asp.net_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Full_Width()
        {
            return View();
        }

        public ActionResult Sidebar_Left()
        {
            return View();
        }
        public ActionResult Sidebar_Right()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Basic_Grid()
        {
            return View();
        }
    }
}