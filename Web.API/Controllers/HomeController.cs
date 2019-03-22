using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
namespace Web.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            string path = Server.MapPath(@"~/Bin/TextFile1.txt");
            if(System.IO.File.Exists(path))
                ViewBag.Title = "Home Page";
            else
                ViewBag.Title = "NONO";

            return View();
        }
    }
}
