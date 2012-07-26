//-----------------------------------------------------------------------
// <copyright file="SocialController.cs" company="Rivensoft Limited">
//     Copyright 2012 Rivensoft Limited. All rights reserved.
// </copyright>
// <author>Adrian Thompson Phillips</author>
//-----------------------------------------------------------------------

namespace Rivensoft.Web.Public.Controllers
{
    using System;
    using System.Configuration;
    using System.Web.Mvc;

    public class SocialController : Controller
    {
        public ActionResult Facebook()
        {
            string redirectUrl = ConfigurationManager.AppSettings["ExternalLink.Social.Facebook"];

            return Redirect(redirectUrl);
        }

        public ActionResult Twitter()
        {
            string redirectUrl = ConfigurationManager.AppSettings["ExternalLink.Social.Twitter"];

            return Redirect(redirectUrl);
        }
    }
}
