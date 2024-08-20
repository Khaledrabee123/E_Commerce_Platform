using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform.prodect
{
    public abstract class Prodect
    {
        public string name { get; set; }
        public int price { get; set; }
       
        public Prodect(string name, int price)
        {
            this.name = name;
            this.price = price;
          
        }
    public abstract void display(); 
    



    }
    



}
