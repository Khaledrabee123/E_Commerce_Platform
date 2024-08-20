namespace E_Commerce_Platform.interfacee
{
    internal class showlabtops
    {
        public static void showlabtop()
        {
            foreach (var item in prodects.Generatelaptops.labtops)
            {
                Console.WriteLine($"labtop number  {item.Key}  ->  ");
                item.Value.display();
            }
            Showdata.additems();

        }
    }
  
}
