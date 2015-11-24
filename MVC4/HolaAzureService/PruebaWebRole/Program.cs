using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaWebRole.AzureServices;

namespace PruebaWebRole
{
  class Program
  {
    static void Main(string[] args)
    {
      AzureServices.HolaServiceClient srvc = new HolaServiceClient();

      Console.WriteLine(srvc.GetSaludo());
      
      Console.ReadLine();
    }
  }
}
