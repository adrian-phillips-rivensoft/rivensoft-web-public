//-----------------------------------------------------------------------
// <copyright file="InfoController.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Web.Public.Controllers
{
    using System;
    using System.Web.Mvc;

    public class InfoController : Controller
    {
        public ActionResult About()
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
