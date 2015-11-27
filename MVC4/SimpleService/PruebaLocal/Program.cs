using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PruebaLocal.AzureService;

namespace PruebaLocal
{
  class Program
  {
    static void Main(string[] args)
    {
      ISimpleService svc = new SimpleServiceClient();

      Console.WriteLine(svc.GetData());
      Console.ReadLine();
    }
  }
}
