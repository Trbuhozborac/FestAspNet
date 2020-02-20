using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrogMusicFest.Controllers
{
    public class IzvodjaciController : Controller
    {
        // GET: Izvodjaci
        public ActionResult Index()
        {
            if (User.IsInRole("AdminDodaje"))
                return View("AdminIndex");
            return View("Index");
        }

    }
}