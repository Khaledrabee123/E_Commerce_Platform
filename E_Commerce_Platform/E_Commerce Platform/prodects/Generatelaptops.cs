using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.prodect;

namespace E_Commerce_Platform.prodects
{
     static class Generatelaptops
    {
       public static Dictionary<int, Labtops> labtops => new Dictionary<int, Labtops>()
        {
                {1,  new Labtops ("ideapad gaming 3", 800, 8, 256 ,"I5 ")} ,
                {2, new Labtops ("ideapad gaming 3", 820 , 8, 512 ,"I5 ")},
                {3,new Labtops ("ideapad gaming 3", 900 , 16,512 ,"I7 ")},
                {4, new Labtops ("dell g15",780, 8, 250 ,"I5 ")},
                {5,new Labtops ("dell g15", 850 , 8, 250 ,"I7 ")},
                {6,new Labtops ("dell g15", 820 , 8, 512 ,"I7 ")},
                {7,new Labtops ("HP Zbook", 500 , 8, 512 ,"I5 ")},
                {8, new Labtops ("HP Zbook", 550, 16, 512 ,"I7 ")}
        };




    }
}
