using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform.prodects
{
    internal class GenerateKeyBoard
    {
        public static Dictionary<int, KeyBoard> KeyBoards => new Dictionary<int, KeyBoard>()
        {
           {1,  new KeyBoard ("KeyBoard ", 100)}
            ,
           {2, new KeyBoard ("Headphone", 50 )}
            ,
            {3,new KeyBoard ("KeyBoard", 30 )}
            ,
           {4, new KeyBoard ("KeyBoard" ,23)}
            ,
            {5,new KeyBoard ("KeyBoard", 120 )}
            ,
            {6, new KeyBoard ("KeyBoard", 70 )}
            ,
            {7,new KeyBoard ("KeyBoard", 60 )}
            ,
           {8, new KeyBoard ("KeyBoard", 132 )}
        };
    }
}
