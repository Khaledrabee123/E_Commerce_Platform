using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform.interfacee
{
    internal class Showdata
    {
        public static void showdata(int ch)
        {
           
            switch (ch)
            {
                case 2:
                    interfacee.showlabtops.showlabtop();
                    break;
                case 3:
                    interfacee.showHeadphones.showHeadphone();
                    break;
                case 4:
                    interfacee.showMouses.sohwMouse();
                    break;
                case 5:
                    interfacee.showKeyboards.sohwKeyboard();
                    break;
                    default:
                    interfacee.faild.invildiproduct();
                    break;

            }
           
        }
        public static void additems()
        {
            Console.WriteLine("to add product enter the number and the quantuty");
        }
    }
}
