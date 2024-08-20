using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.Card;
namespace E_Commerce_Platform.customers
{
    internal static class Generatecustomers
    {
        //public Customers(string name, int age, int id, string email, string pass)
       public  static Dictionary<int, Customers> Customers_indatabase = new Dictionary<int, Customers>()
        {
            {1, new Customers("Khaled",20, 1, "khaledrabee040@gmail.com", "Khaled123" , 4000 ) },
            {2, new Customers("Ahamed",20, 2, "Ahmedrabee040@gmail.com", "ahmed123" , 2000) },
            {3, new Customers("Mohamed",20, 3, "Mohamedrabee040@gmail.com", "mohamed123",6000) },
            {5, new Customers("Ali",20, 5, "Alirabee040@gmail.com", "ali123", 9000)},
            {4, new Customers("mona",20, 4, "monarabee040@gmail.com", "mona123",500) },

        };
    }
}
