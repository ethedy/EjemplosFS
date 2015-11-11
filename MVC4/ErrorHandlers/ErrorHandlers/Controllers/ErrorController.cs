using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandlers.Controllers
{
  public class ErrorController : Controller
  {
    //  Lanza una excepcion que deberia ser capturada por el handler por defecto de ASP.NET
    public ActionResult DefaultError()
    {
      throw new ApplicationException("DefaultError Action Error");
      return new EmptyResult();
    }

    //  Lanza una excepcion que será capturada por el filtro de excepcion colocado en el mismo metodo
    [HandleError(View = "HandlerAttributeError")]
    public ActionResult HandlerAttributeError()
    {
      throw new ApplicationException("HandlerAttributeError Action Error");
      return new EmptyResult();
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}
