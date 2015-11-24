using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAX.Controllers
{
  public class HelloController : Controller
  {
    // GET: Hello
    public ActionResult World()
    {
      ViewBag.Mensaje = "Hola...";
      return View();
    }

    [HttpPost]
    public PartialViewResult HelloWorld()
    {
      ViewBag.Mensaje = string.Format("Hola Mundo!!! Partial View Son las {0:HH:mm:ss} del dia {0:M} del {0:yyyy}", DateTime.Now);
      return PartialView();
    }

    public ActionResult HelloWorldRefresh()
    {
      ViewBag.Mensaje = string.Format("Hola Mundo!!! Son las {0:HH:mm:ss} del dia {0:M} del {0:yyyy}", DateTime.Now);
      return View();
    }
  }
}