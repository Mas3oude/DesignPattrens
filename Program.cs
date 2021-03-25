using DesignPatterns._01AbstractFactory;
using DesignPatterns._01AbstractFactory.NokiaPhone;
using DesignPatterns._01AbstractFactory.SamsungPhone;
using DesignPatterns._02FactoryMethod;
using DesignPatterns._02FactoryMethod.Documents;
using DesignPatterns._02StructuralPatterns._07Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 01 Creation Patterns
            #region 01 Abstract Factory 
            //ISmartPhone smartPhone;
            //INormalPhone normalPhone;

            IMobilePhone nokiaPhone = new Nokia();

            Console.WriteLine(nokiaPhone.GetNormalPhone().GetModelDetials());
            Console.WriteLine(nokiaPhone.GetSmartPhone().GetModelDetials());


            IMobilePhone samsungPhone = new Samsung();
            Console.WriteLine(samsungPhone.GetNormalPhone().GetModelDetials());
            Console.WriteLine(samsungPhone.GetSmartPhone().GetModelDetials());
            #endregion


            #region 02 Factory Method
            //Document[] documents = new Document[2];
            var documents = new List<Document>();
            documents.Add(new Resume());
            documents.Add(new Report());

            foreach (var item in documents)
            {
                Console.WriteLine("-" + item.GetType().Name);
                foreach (var page in item.Pages)
                {
                    Console.WriteLine("   -"+ page.GetType().Name);
                }
            }
            #endregion

            #endregion

            #region 02 Structural Patterns
            #region 07 Proxy
            IMath proxy = new MathProxy();

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));
            #endregion
            #endregion

            #region 03 Behavioral Patterns
            #endregion
            FinishProgram();
        }

        private static void FinishProgram()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("******************END OF THE PROGRAM *********************************");
            Console.ReadLine();
        }
    }
}
