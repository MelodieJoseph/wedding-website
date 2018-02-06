using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeddingGallery.Controllers
{
    public class HarryPotterController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                //return new RedirectResult("/");
                return Redirect("/");
            }

            //return new ContentResult()
            //{
            //    Content = "Hello from the Harry Potter Controller!"
            //};

            return Content("Hello from the Harry Potter Controller!");

        }
    }
}