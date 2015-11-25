using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace HolaAzureWorker
{
  public class WorkerRole : RoleEntryPoint
  {
    private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
    private readonly ManualResetEvent runCompleteEvent = new ManualResetEvent(false);

    public static string CommonArea;

    public override void Run()
    {
      Trace.TraceInformation("HolaAzureWorker is running");

      Trace.TraceInformation("Bindeando el endpoint interno al servicio");

      var internalEndpoint = RoleEnvironment.CurrentRoleInstance.InstanceEndpoints["InternalWorker"];
      var serviceAddress = new Uri(string.Format("net.tcp://{0}", internalEndpoint.IPEndpoint.ToString()));

      Trace.TraceInformation(serviceAddress.ToString());

      var serviceHost = new ServiceHost(typeof(WorkerInternalService), serviceAddress);
      var binding = new NetTcpBinding(SecurityMode.None);

      serviceHost.AddServiceEndpoint(typeof (IWorkerInternalService), binding, "helloservice");

      try
      {
        serviceHost.Open();
        this.RunAsync(this.cancellationTokenSource.Token).Wait();
      }
      finally
      {
        this.runCompleteEvent.Set();
        serviceHost.Close();
      }
    }

    public override bool OnStart()
    {
      // Set the maximum number of concurrent connections
      ServicePointManager.DefaultConnectionLimit = 12;

      // For information on handling configuration changes
      // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.

      bool result = base.OnStart();

      Trace.TraceInformation("HolaAzureWorker has been started");

      return result;
    }

    public override void OnStop()
    {
      Trace.TraceInformation("HolaAzureWorker is stopping");

      this.cancellationTokenSource.Cancel();
      this.runCompleteEvent.WaitOne();

      base.OnStop();

      Trace.TraceInformation("HolaAzureWorker has stopped");
    }

    private async Task RunAsync(CancellationToken cancellationToken)
    {
      // el worker lo unico que hace es esperar...y cambiar la fecha cada 5 segundos
      while (!cancellationToken.IsCancellationRequested)
      {
        Trace.TraceInformation("Working");

        CommonArea = DateTime.Now.ToString("O");

        await Task.Delay(5000);
      }
    }
  }
}
