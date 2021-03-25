using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01AbstractFactory.NokiaPhone
{
    class Nokia1600 : INormalPhone
    {
        public string GetModelDetials()
        {
            var productName = "Hello this is Nokia 1600 Normal Phone ";
           // Console.WriteLine(productName);
            return productName;
        }
    }
}
