using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace HolaAzureRole
{
  // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HolaService" in code, svc and config file together.
  // NOTE: In order to launch WCF Test Client for testing this service, please select HolaService.svc or HolaService.svc.cs at the Solution Explorer and start debugging.
  public class HolaService : IHolaService
  {
    public string GetSaludo()
    {
      Trace.TraceInformation("Accediendo al servicio interno...");

      //  como hago para obtener una propiedad desde la clase web role
      Trace.TraceInformation("Funcionando...a punto de saludar...");
      return "Hola Mundo Azure!!";
    }
  }
}
