using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bundles.Models;

namespace Bundles.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<Modelo> l = new List<Modelo>()
            {
              new Modelo() { Propiedad = "Cadena", Propiedad1 = 200}
            };
            return View(l);
        }

    }
}
