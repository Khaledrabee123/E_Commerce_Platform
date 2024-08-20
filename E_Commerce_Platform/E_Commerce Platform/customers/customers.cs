using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.Card;
using E_Commerce_Platform.prodect;

namespace E_Commerce_Platform.customers
{
    internal class Customers
    {
        public string Name { get; set; }
        public int age { get; set; }

        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int money { get; set; }
        public Dictionary<Prodect, int> card {  get; set; } 

        public Customers(string name , int age, int id , string email , string pass , int money) 
        {
            Name = name;
            this.age = age;
            this.id = id;
            this.email = email;
            this.password = pass;
            this.money = money;
            card = new Dictionary<Prodect, int>();
            

        }
        public void display()
        {
            Console.WriteLine($"Name -> {Name} , age ->{age}  , id  -> {id}  , Email -> {email}");
        }

  


    }
}
