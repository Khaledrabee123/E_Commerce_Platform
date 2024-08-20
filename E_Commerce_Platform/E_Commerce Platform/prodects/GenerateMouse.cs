using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform.prodects
{
    internal class GenerateMouse
    {
        public static Dictionary<int, mouse> mouses => new Dictionary<int, mouse>()
        {

            {1,  new mouse ("mouse ", 100)}
            ,
            {2, new mouse ("mouse", 50)}
            ,
            {3,new mouse ("mouse", 30 )}
            ,
           {4, new mouse ("mouse" ,23)}
            ,
            {5,new mouse ("mouse", 120 )}
            ,
            {6, new mouse ("mouse", 70)}
            ,
            {7,new mouse ("mouse", 60 )}
            ,
           {8, new mouse ("mouse", 132 )}
        };
    }
}
