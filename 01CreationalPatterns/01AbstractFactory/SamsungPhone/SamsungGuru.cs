using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._01AbstractFactory.SamsungPhone
{
    class SamsungGuru : INormalPhone
    {
        public string GetModelDetials()
        {
            var productName = "Hello this is Samsung Guru phone";
          // Console.WriteLine(productName);
            return productName;
        }
    }
}
