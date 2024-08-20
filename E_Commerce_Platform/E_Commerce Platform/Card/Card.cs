using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.prodect;
using E_Commerce_Platform.prodects;
using E_Commerce_Platform.customers;
using System.Net.Http.Headers;
namespace E_Commerce_Platform.Card

{
    internal static class Card
    {
     

        
          public static void  Displaycard(customers.Customers customer)
           {
            

            foreach (var item in customer.card)
            {
                int i = item.Value;
                while (i>0)
                {
                    item.Key.display();
                    i--;
                }

            }
            Console.WriteLine("to buy press 1");




           }

        public static int cardsize(customers.Customers customer)
        {
            return customer.card.Count;
        }
       public static void AddToCart(Prodect prodect, int quantity,customers.Customers customers)
        {
         
            if ( customers.card.ContainsKey(prodect))
            {
                customers.card[prodect] += quantity; 
            }
            else
            {
                customers.card[prodect] = quantity; 
            }
            interfacee.madesucess.added();
        }
        public static void removeproduct(Prodect prodect, int Q , customers.Customers customer)
        {

            if (!customer. card.ContainsKey(prodect))
            {
                Console.WriteLine("product not found");
            }
           if ( customer.card.ContainsKey(prodect))
            {
                if (Q > customer.card[prodect])
                {
                    Console.WriteLine("faild");
                }
                else
                {
                    customer.card[(prodect)] -= Q;
                  
                }
            }
            if (customer.card[prodect] == 0)
            {
                customer.card.Remove(prodect);
            }
            Console.WriteLine("product removed sucssesfly");
        }
        public static int totalprice(customers.Customers customer)
        {
            int total = 0;  
            foreach (var item in customer.card)
            {
                total += item.Key.price * item.Value;
            }
            return total;
        }


    }
}
