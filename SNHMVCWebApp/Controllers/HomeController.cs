﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SNHMVCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "SNHIntegration Home Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact SNH!";

            return View();
        }
    }
}