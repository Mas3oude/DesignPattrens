using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01AbstractFactory.NokiaPhone
{
    class NokiaPixel : ISmartPhone
    {
        public string GetModelDetials()
        {
            var productName = "Hello this is Nokia Pixed Phone";
           // Console.WriteLine(productName);
            return productName;
        }
    }
}
