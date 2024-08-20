using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform.interfacee
{
    internal class showKeyboards
    {
        public static void sohwKeyboard()
        {
            foreach (var item in prodects.GenerateKeyBoard.KeyBoards)
            {
                Console.WriteLine($"labtop number  {item.Key}  ->  ");
                item.Value.display();
            }
            Showdata.additems();

        }
    }
}
