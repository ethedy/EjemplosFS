using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HolaAzureWorker;
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

      Trace.TraceInformation("Intentando crear el proxy del servicio interno...");

      string pid = Process.GetCurrentProcess().Id.ToString();
      string ppid = Process.GetCurrentProcess().ProcessName;
      
      string wip =
        RoleEnvironment.Roles["HolaAzureWorker"].Instances[0].InstanceEndpoints["InternalWorker"].IPEndpoint.ToString();

      Trace.TraceInformation(wip);

      var serviceAddress = new Uri(string.Format("net.tcp://{0}/{1}", wip, "helloservice"));
      var endpointAddress = new EndpointAddress(serviceAddress);
      var binding = new NetTcpBinding(SecurityMode.None);

      var service = ChannelFactory<IWorkerInternalService>.CreateChannel(binding, endpointAddress);
      
      //  var service = WebRole.factory.CreateChannel();

      string hora = service.GetInformacion();

      //  como hago para obtener una propiedad desde la clase web role
      Trace.TraceInformation("Funcionando...a punto de saludar...");
      return string.Format("Hola Mundo Azure!! {0}", hora);
    }
  }
}
