using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;

using HolaAzureWorker;

namespace HolaAzureRole
{
  public class WebRole : RoleEntryPoint
  {
    public static IWorkerInternalService service;

    public static ChannelFactory<IWorkerInternalService> factory;

    public static StringBuilder pirulo;

    public override bool OnStart()
    {
      // For information on handling configuration changes
      // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.
      Trace.TraceInformation("OnStart llamado en WebRole");
/*
      Trace.TraceInformation("Intentando crear el proxy del servicio interno...");

      string pid = Process.GetCurrentProcess().Id.ToString();
      string ppid = Process.GetCurrentProcess().ProcessName;

      string wip =
        RoleEnvironment.Roles["HolaAzureWorker"].Instances[0].InstanceEndpoints["InternalWorker"].IPEndpoint.ToString();

      Trace.TraceInformation(wip);

      var serviceAddress = new Uri(string.Format("net.tcp://{0}/{1}", wip, "helloservice"));
      var endpointAddress = new EndpointAddress(serviceAddress);
      var binding = new NetTcpBinding(SecurityMode.None);

      WebRole.factory = new ChannelFactory<IWorkerInternalService>(binding, endpointAddress);

      //  service = ChannelFactory<IWorkerInternalService>.CreateChannel(binding, endpointAddress);
      //  service.GetInformacion();

      WebRole.pirulo = new StringBuilder("PIRULO");
*/
      return base.OnStart();
    }
  }
}
