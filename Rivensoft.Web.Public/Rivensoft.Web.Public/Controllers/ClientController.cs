//-----------------------------------------------------------------------
// <copyright file="ClientController.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Web.Public.Controllers
{
    using System;
    using System.Web.Mvc;

    public class ClientController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
