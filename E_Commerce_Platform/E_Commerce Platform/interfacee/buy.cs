using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform.interfacee
{
    internal class Buy
    {
         public static bool Isoktobuy(customers.Customers customer, int total)
         {
            if (customer.money >= total)
            {
                customer.money -= total;
                
                return true;
            }

            return false;
         }
    }
}
