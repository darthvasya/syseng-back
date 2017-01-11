﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace syseng.Web.Controllers
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

        public ActionResult Articles()
        {
            ViewBag.Message = "Your articles page.";

            return View();
        }

        public ActionResult Article()
        {
            ViewBag.Message = "Your article page.";

            return View();
        }
    }
}