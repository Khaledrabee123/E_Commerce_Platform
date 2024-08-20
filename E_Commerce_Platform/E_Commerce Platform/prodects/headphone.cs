using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.prodect;

namespace E_Commerce_Platform.prodects
{
    public class Headphone : Prodect
    {
        public Headphone(string name, int price) : base(name, price )
        {
        }
        public override void display()
        {
            Console.WriteLine($"Name -> {name}");
            Console.WriteLine($"Price -> {price}$  ");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        }
    }


}

