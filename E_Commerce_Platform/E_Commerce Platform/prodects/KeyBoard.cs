using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.prodect;

namespace E_Commerce_Platform.prodects
{
    internal class KeyBoard : Prodect
    {
        public KeyBoard(string name, int price) : base(name, price )
        {
        }
        public override void display()
        {
            Console.WriteLine($"Name -> {name}");
            Console.WriteLine($"Price -> {price}$ ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        }

    }
}
