using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.customers;

namespace E_Commerce_Platform.interfacee
{
    internal class login
    {

        public static void enterdata()
        {
            Console.WriteLine($"enter the id and passwored to login");
        }
        public static bool correct(int username, string password)
        {
            if (!customers.Generatecustomers.Customers_indatabase.ContainsKey(username))
            {
                interfacee.faild.notfound();
                return false;
            }
            if (customers.Generatecustomers.Customers_indatabase[username].password == password)
            {
                interfacee.madesucess.loginsucssefuly();
                return true;
            }

            interfacee.faild.invailadpassword();
            return false;
        }
      




    }
}
