using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.customers;

namespace E_Commerce_Platform.prodects
{
    internal class GenerateHeadphone
    {
        public static Dictionary<int, Headphone> Headphones => new Dictionary<int, Headphone>()
        {

          {1,  new Headphone ("Headphone ", 100)}
            ,
           {2, new Headphone ("Headphone", 50 )}
            ,
            {3,new Headphone ("Headphone", 30 )}
            ,
           {4, new Headphone ("Headphone" ,23)}
            ,
            {5,new Headphone ("Headphone", 120 )}
            ,
            {6, new Headphone ("Headphone", 70 )}
            ,
            {7,new Headphone ("Headphone", 60 )}
            ,
           {8, new Headphone ("Headphone", 132)}
        };
    }
}
