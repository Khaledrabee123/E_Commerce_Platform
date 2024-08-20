using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform.interfacee
{
    internal class showHeadphones
    {
        public static void showHeadphone()
        {
            foreach (var item in prodects.GenerateHeadphone.Headphones)
            {
                Console.WriteLine($"Headphone number  {item.Key}  ->  ");
                item.Value.display();
            }
            Showdata.additems();
        }
    }
}
