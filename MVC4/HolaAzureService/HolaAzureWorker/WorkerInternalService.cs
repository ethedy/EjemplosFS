using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HolaAzureWorker
{
  [ServiceContract]
  public interface IWorkerInternalService
  {
    [OperationContract]
    string GetInformacion();
  }

  [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
  public class WorkerInternalService : IWorkerInternalService
  {
    public string GetInformacion()
    {
      Trace.TraceInformation("Retornando el valor solicitado");
      return WorkerRole.CommonArea;
    }
  }
}
