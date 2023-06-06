using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BuyersGuide
{
    class Program
    {
         static void Main(string[] args)
         {
            //list with ALL shop
            List<Shop> list_shop = new List<Shop>();

            //encoding to Ukrainian letters
            Console.OutputEncoding = Encoding.Unicode;

            bool flag = true;
            int choice = 0;
            Console.WriteLine(" Привіт!\nВітаю в програмі \"Довідник покупця\"");
            while (flag)
            {
                Console.WriteLine("\nОсь чим наш довідник може допомогти: \n 1 - Додати магазин.\n 2 - Подивитися інформацію про всі магазини.\n 3 - Знайти магазин.\n 4 - Видалити магазин.\n 5 - Конвертувати інформацію у файл.\n 6 - Припинити програму.");
                Console.Write("Обери номер опції: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nОбери спеціалізацію магазину, який хочеш додати:\n - Продукти;\n - Промислові товари;\n - Іграшки;\n - Біжутерія;\n - Книги;\n - Одяг;\n - Кафе;\n - Ресторан;\n - Універсам;\n - Супермаркет;\n - Торговий центр;");
                        Console.Write("\nНапиши тип спеціалізації: ");
                        string spec_choice = Console.ReadLine();
                        Console.Write("\nВведіть назву магазину: ");
                        string name_shop = Console.ReadLine();
                        Console.Write("\nВведіть адресу магазину: ");
                        string address_shop = Console.ReadLine();
                        Console.Write("\nВведіть час роботи: ");
                        string time_shop = Console.ReadLine();

                        //Іфами визначаю, який вид магазину створити
                        if (spec_choice.ToLower() == "продукти")
                        {
                            GroceryShop shop = new GroceryShop();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "промислові товари")
                        {
                            IndusrialShop shop = new IndusrialShop();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "іграшки")
                        {
                            ToyShop shop = new ToyShop();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "біжутерія")
                        {
                            JewelleryShop shop = new JewelleryShop();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "книги")
                        {
                            BookShop shop = new BookShop();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "одяг")
                        {
                            ClothesShop shop = new ClothesShop();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "кафе")
                        {
                            Cafe shop = new Cafe();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "ресторан")
                        {
                            Restaurant shop = new Restaurant();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "універсам")
                        {
                            Market shop = new Market();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "супермаркет")
                        {
                            Supermarket shop = new Supermarket();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else if (spec_choice.ToLower() == "торговий центр")
                        {
                            ShoppingCenter shop = new ShoppingCenter();
                            shop.AddShop(name_shop, address_shop, time_shop);
                            list_shop.Add(shop);
                        }
                        else
                        {

                        }
                        Console.WriteLine("\nВаш магазин додано!");
                        break;
                    case 2:
                        Console.WriteLine("\nОсь інформація про магазини:");
                        foreach (Shop el in list_shop)
                        {
                            el.PrintInfo();
                        }
                        break;
                    case 3:
                        Console.Write("\nПошук магазину.\nВведіть назву магазину: ");
                        string find_name = Console.ReadLine();
                        Console.WriteLine("\nШуканий магазин: ");
                        foreach(Shop el in list_shop)
                        {
                            if(find_name == el.Name)
                                el.PrintInfo();
                        }
                        break;
                    case 4:
                        Console.Write("\nДавайте видалимо магазин.\nВведіть назву магазину, який хочете видалити: ");
                        string del_name = Console.ReadLine();
                        for (int i = list_shop.Count - 1; i >= 0; i--)
                        {
                            if (del_name == list_shop[i].Name)
                                list_shop.RemoveAt(i);
                        }
                        break;
                    case 5:
                        string filePath = "D:\\gitreps\\op\\op-kp21-bonkovskyi\\sem_2_coursework\\Buyers_Guide.csv";
                        using (StreamWriter sr = new StreamWriter(filePath, append: true, encoding: Encoding.UTF8))
                        {
                            foreach(Shop el in list_shop)
                            {
                                string text = $"{el.Name};{el.Address};{el.ukrTypeShop};{el.WorkingHours}";
                                sr.WriteLine(text);
                            }
                        }
                        Console.WriteLine("\nІнформація про магазини конвертована в файл!");
                        break;
                    case 6:
                        Console.WriteLine("\nРобота програми призупинена.");
                        flag = false;
                        break;

                    default:
                        break;
                }
            }
            

            //StreamWriter sw = new StreamWriter("D:\\gitreps\\op\\op-kp21-bonkovskyi\\sem_2_coursework\\Buyers_Guide.csv");
            //sw.Close();

            //shop_1.Name = "Будинок ірашок";
            //Console.WriteLine(shop_1.Name);

            //shop_1.AddShop("Будинок іграшок", "вул. Хрещатик 1", Ownership.Corporation, "5:00 - 21:00");
            //shop_1.PrintInfo();
        }
        
    }
}