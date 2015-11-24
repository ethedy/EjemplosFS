using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HolaAzureInternalService
{
  [ServiceContract]
  public interface IInternalService
  {

    [OperationContract]
    string SaludoInternal(int value);
  }
}
