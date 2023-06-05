using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersGuide
{
    class Program
    {
         static void Main(string[] args)
         {
            Console.OutputEncoding = Encoding.Unicode;
            ToyShop shop_1 = new ToyShop();
            GroceryShop shop_2 = new GroceryShop();

            //StreamWriter sw = new StreamWriter("D:\\gitreps\\op\\op-kp21-bonkovskyi\\sem_2_coursework\\Buyers_Guide.csv");
            //sw.WriteLine();
            //sw.WriteLineAsync("Faid; Close; Or; Open;");
            //sw.WriteLine("Kali; Daorl; Pear;");
            //sw.Close();
            
            //shop_1.Name = "Будинок ірашок";
            //Console.WriteLine(shop_1.Name);

            shop_1.AddShop("Будинок іграшок", "вул. Хрещатик 1", Ownership.Corporation, "5:00 - 21:00");
            shop_1.PrintInfo();
         }
        
    }
}