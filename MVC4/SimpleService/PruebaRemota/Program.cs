using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PruebaRemota.AzureServiceRemoto;

namespace PruebaRemota
{
  class Program
  {
    static void Main(string[] args)
    {
      ISimpleService srvc = new SimpleServiceClient();

      Console.WriteLine(srvc.GetData());
      Console.ReadLine();
    }
  }
}
