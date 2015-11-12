using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandlers.Controllers
{
  public class OnExceptionController : Controller
  {
    //
    // GET: /OnException/

    public ActionResult GenerarError()
    {
      throw new ApplicationException("GenerarError OnException Action Error");
      return new EmptyResult();
    }

    protected override void OnException(ExceptionContext filterContext)
    {
      if (filterContext.Exception is ApplicationException)
      {
        filterContext.Result = new ViewResult()
        {
          ViewName = "OnException",
          ViewData = new ViewDataDictionary<string>(filterContext.Exception.Message)
        };
        filterContext.ExceptionHandled = true;
      }
    }
  }
}
