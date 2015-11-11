using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*
 
  Para que funcione NO USAR el administrador de paquetes, sino la consola
 
  EJECUTAR: 
 
  Install-Package MvcSiteMapProvider -Version 3.3.6
 
  Esta es la ultima version que no usa DI, por eso no arrancaba en el curso
 
 */
namespace SiteMapProvider.Controllers
{
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
  }
}
