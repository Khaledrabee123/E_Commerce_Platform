using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Commerce_Platform.prodect;
namespace E_Commerce_Platform.prodects
{
    internal class Getproduct
    {
        public static Prodect getproduct(int ch, int id)
        {
            switch (ch)
            {
                case 2:

                    return prodects.Generatelaptops.labtops[id];
                    break;
                case 3:
                    return prodects.GenerateHeadphone.Headphones[id];
                    break;
                case 4:
                    return prodects.GenerateMouse.mouses[id];
                    break;
                case 5:
                    return prodects.GenerateKeyBoard.KeyBoards[id];
                    break;
                default:
                    interfacee.faild.invildiproduct();
                    break;
            }
            return null;
        }
    }
}
