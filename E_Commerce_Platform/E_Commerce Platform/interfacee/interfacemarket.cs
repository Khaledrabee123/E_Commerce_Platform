using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform.interfacee
{
    internal class interfacemarket
    {
        public static void showitems (customers.Customers customer ){
            Console.WriteLine($"hello Mr {customer.Name}              show your card press 1");
            Console.WriteLine("select what do you want");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("2-labtops");
            Console.WriteLine("3-Headphones");
            Console.WriteLine("4-Mouses");
            Console.WriteLine("5-Keyboards");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("back press 6");
        }

    }
}
