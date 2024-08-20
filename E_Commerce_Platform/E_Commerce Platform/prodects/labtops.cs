using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.prodect;

namespace E_Commerce_Platform.prodects
{
    class Labtops : Prodect
    {
        int RAM;
        int Storige;
        string Procesor;
        public Labtops(string name, int price , int ram , int storige , string procesor) : base(name, price)
        {
            RAM = ram;
            Storige = storige;
            Procesor = procesor;

        }
        public override void display()
        {
            Console.WriteLine($"Name -> {name}   RAM -> {RAM }  Storige -> {Storige} ssd   Procesor ->{Procesor} ");
            Console.WriteLine($"Price -> {price}$" );
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        }

       
    }
}
