﻿namespace BetSystem.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Navigation()
        {
            return View(DateTime.Now);
        }
    }
}