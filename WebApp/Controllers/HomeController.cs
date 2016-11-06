using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;
using System.Net;

namespace WebApp.Controllers
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
                
        public ActionResult Game()
        {
            ViewBag.Message = "Game.";

            return View();
        }

        public ActionResult Kanban()
        {
            ViewBag.Message = "Kanban.";

            return View();
        }

    }
}