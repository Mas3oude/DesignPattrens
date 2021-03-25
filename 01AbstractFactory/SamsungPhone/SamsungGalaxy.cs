using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01AbstractFactory.SamsungPhone
{
    class SamsungGalaxy : ISmartPhone
    {
        public string GetModelDetials()
        {
            var productName = "Hello this is samsun galaxy";
            //Console.WriteLine(productName);
            return productName;
        }
    }
}
