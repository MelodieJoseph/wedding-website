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
            ViewBag.WhatsHappening = "Mel and Art's Harry Potter wedding!";
            ViewBag.WeddingDate = new DateTime(2019, 3, 9, 16, 0, 0);

            ViewBag.Description = "You are cordially invited to the wedding of Artem Igorevich Shkumat and Melodie Laura Joseph <br /> We will be taking the Lebedev name";
            ViewBag.Venues = new string[]
            {
                "Ceremony: St Patrick's Cathedral",
                "Reception: TBC"
            };

            return View();

        }
    }
}