//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Web.Public.Controllers
{
    using System;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Clients()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Development()
        {
            return View();
        }
    }
}
