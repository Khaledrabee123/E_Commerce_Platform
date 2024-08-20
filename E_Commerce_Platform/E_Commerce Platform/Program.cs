using System;
using System.Collections.Specialized;
using System.Transactions;
using E_Commerce_Platform.customers;
using E_Commerce_Platform.interfacee;
using E_Commerce_Platform.prodect;
using E_Commerce_Platform.prodects;

namespace E_Commerce_Platform
{
    public class Program
    {
    static void Main(string[] args)
{
    int id;
    string password;
    string c;

    do
    {


        interfacee.login.enterdata();
        id = Convert.ToInt32(Console.ReadLine());
        password = Console.ReadLine();
        if (interfacee.login.correct(id, password))
        {

            int ch;
            Console.Clear();
            interfacee.interfacemarket.showitems(customers.Generatecustomers.Customers_indatabase[id]);
            ch = Convert.ToInt32(Console.ReadLine());
            if (ch == 1)
            {
                do
                {
                   if (Card.Card.cardsize(customers.Generatecustomers.Customers_indatabase[id]) == 0)
                    {
                        interfacee.faild.empty();

                    }
                    else
                    {
                        Card.Card.Displaycard(customers.Generatecustomers.Customers_indatabase[id]);
                        int ok = Convert.ToInt32(Console.ReadLine());
                        if (ok == 1)
                        {
                            if (interfacee.Buy.Isoktobuy(customers.Generatecustomers.Customers_indatabase[id], Card.Card.totalprice(customers.Generatecustomers.Customers_indatabase[id])))
                            {
                                customers.Generatecustomers.Customers_indatabase[id].card.Clear();
                                
                                interfacee.madesucess.madesucesss();
                            }
                        }
                    }
                    Console.WriteLine("do u need any opration  y / n ");
                    c = Console.ReadLine();
                    
                     } while (c.Equals("y"));

            }
            else
            {
                do
                {
                    Console.Clear();
                    interfacee.interfacemarket.showitems(customers.Generatecustomers.Customers_indatabase[id]);
                    if (ch == 6)
                    {
                        break;
                    }
                    interfacee.Showdata.showdata(ch);
                    int idproduct = Convert.ToInt32(Console.ReadLine());
                    int quntaty = Convert.ToInt32(Console.ReadLine());
                    Prodect prodect = prodects.Getproduct.getproduct(ch, idproduct);
                    Card.Card.AddToCart(prodect, quntaty, customers.Generatecustomers.Customers_indatabase[id]); 
                    
                    Console.WriteLine("do u need add another product  y / n ");
                    c = Console.ReadLine();
                }
                while (c.Equals("y"));
            }





        }








    } while (true);

}
    }
}
