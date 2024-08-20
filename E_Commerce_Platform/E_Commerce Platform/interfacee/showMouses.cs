using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform.interfacee
{
    internal class showMouses
    {
     
            public static void sohwMouse()
            {
                foreach (var item in prodects.GenerateMouse.mouses)
                {
                    Console.WriteLine($"mouse number   {item.Key}  ->  ");
                item.Value.display();
                }
            Showdata.additems();

            }



    }
}
