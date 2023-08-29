using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyersGuide
{
    public class ShopOperations
    {
        public static List<Shop> list_shop = new List<Shop>();

        public static void AddShop()
        {
            Console.Write("\nВведіть назву магазину: ");
            string name_shop = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name_shop))
            {
                Console.WriteLine("Введено некоректну назву магазину.");
                return;
            }

            Console.Write("\nВведіть адресу магазину: ");
            string address_shop = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(address_shop))
            {
                Console.WriteLine("Введено некоректну адресу магазину.");
                return;
            }

            Console.Write("\nВведіть час роботи (у форматі 00:00-00:00/цілодобово): ");
            string time_shop = Console.ReadLine();

            Console.WriteLine("\nОберіть форму власності: \n1 - Одноосібне володіння.\n2 - Товариство\n3 - Корпорація.\n4 - Державне підприємство.");
            Console.Write("\nНапишіть потрібний номер: ");
            int owner_choice;
            if (!int.TryParse(Console.ReadLine(), out owner_choice))
            {
                Console.WriteLine("Введено некоректне значення. Будь ласка, введіть число.");
                return;
            }

            Console.WriteLine("\nОбери спеціалізацію магазину, який хочеш додати:\n - Продукти;\n - Промислові товари;\n - Тварини\n - Дитячі товари;\n - Біжутерія;\n - Книги;\n - Одяг;\n - Кафе;\n - Ресторан;\n - Універсам;\n - Супермаркет;\n - Торговий центр;");
            Console.Write("\nНапиши тип спеціалізації: ");
            string spec_choice = Console.ReadLine();

            Dictionary<string, Type> shopTypes = new Dictionary<string, Type>
            {
                  {"продукти", typeof(GroceryShop)},
                  {"промислові товари", typeof(IndusrialShop)},
                  {"тварини", typeof(PetShop) },
                  {"дитячі товари", typeof(ToyShop)},
                  {"біжутерія", typeof(JewelleryShop)},
                  {"книги", typeof(BookShop)},
                  {"одяг", typeof(ClothesShop)},
                  {"кафе", typeof(Cafe)},
                  {"ресторан", typeof(Restaurant)},
                  {"універсам", typeof(Market)},
                  {"супермаркет", typeof(Supermarket)},
                  {"торговий центр", typeof(ShoppingCenter)}
            };

            if (shopTypes.ContainsKey(spec_choice.ToLower()))
            {
                Type shopType = shopTypes[spec_choice.ToLower()];
                Shop shop = (Shop)Activator.CreateInstance(shopType);
                shop.AddShop(name_shop, address_shop, (Ownership)owner_choice, time_shop);

                if (shop is Market)
                {
                    Console.Write("\nВведіть тип товарів (через кому), що має цей універсам: ");
                    string textProdList = Console.ReadLine();
                    string[] prodList = textProdList.Split(',');
                }
                if (shop is ShoppingCenter)
                {
                    Console.WriteLine("\nЯкі магазини містяться в цьому торговому центрі:\n1 - Додати існуючий. \n2 - Додати новий.");
                    int sh_choice;

                    if (!int.TryParse(Console.ReadLine(), out sh_choice))
                    {
                        Console.WriteLine("Введено некоректне значення. Будь ласка, введіть число.");
                        return;
                    }

                    switch (sh_choice)
                    {
                        case 1:
                            PrintAllShopsInfo();
                            Console.WriteLine("\nВведіть назву існуючого магазину зі списку: ");
                            string na_choice = Console.ReadLine();
                            foreach (Shop _shop in list_shop)
                            {
                                if (na_choice == _shop.Name)
                                    ((ShoppingCenter)shop).AddShopInSC(_shop);
                            }
                            break;
                        case 2:
                            AddShop();
                            ((ShoppingCenter)shop).AddShopInSC(shop);
                            break;
                        default:
                            Console.WriteLine("Введено некоректне значення. Будь ласка, виберіть варіант 1 або 2.");
                            return;
                    }
                }
                list_shop.Add(shop);
                Console.WriteLine("\nВаш магазин додано!");
            }
            else
            {
                Console.WriteLine("\nНевідомий тип спеціалізації магазину.");
            }
        }

        public static void DeleteShop()
        {
            Console.WriteLine("Введіть пароль, щоб видалити магазин: ");
            string code = Console.ReadLine();
            if (code != "1234")
                Console.WriteLine("Не правильний пароль!");
            else
            {
                Console.Write("\nДавайте видалимо магазин.\nВведіть назву магазину, який хочете видалити: ");
                string del_name = Console.ReadLine();
                bool foundShop = false;

                for (int i = list_shop.Count - 1; i >= 0; i--)
                {
                    if (del_name == list_shop[i].Name)
                    {
                        list_shop.RemoveAt(i);
                        foundShop = true;
                    }
                }

                if (foundShop)
                {
                    Console.WriteLine("\nЦей магазин видалено!");
                }
                else
                {
                    Console.WriteLine("\nМагазин з такою назвою не знайдено.");
                }
            }
        }

        public static void PrintAllShopsInfo()
        {
            Shop.SortShopsByName(list_shop);
            Console.WriteLine("\nОсь інформація про магазини:");
            foreach (Shop shop in list_shop)
            {
                shop.PrintInfo();
            }
        }

        public static void FindShop()
        {
            Console.Write("\nПошук магазину.\nВведіть назву магазину: ");
            string find_name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(find_name))
            {
                Console.WriteLine("Введено некоректну назву магазину.");
                return;
            }

            Console.WriteLine("\nШуканий магазин: ");
            bool foundShop = false;

            foreach (Shop shop in list_shop)
            {
                if (find_name.Equals(shop.Name, StringComparison.OrdinalIgnoreCase))
                {
                    shop.PrintInfo();
                    foundShop = true;
                }
            }

            if (!foundShop)
            {
                Console.WriteLine("Магазин з такою назвою не знайдено.");
            }
        }

        public static void ConvertToCSV()
        {
            string filePath = "D:\\gitreps\\op\\op-kp21-bonkovskyi\\sem_2_coursework\\Buyers_Guide.csv";
            using (StreamWriter sw = new StreamWriter(filePath, append: true, encoding: Encoding.UTF8))
            {
                foreach (Shop shop in list_shop)
                {
                    string text = $"{shop.Name},{shop.Address},{shop.ukrTypeShop},{shop.WorkingHours},{shop.ukrOwnership}";
                    sw.WriteLine(text);
                }
            }
            Console.WriteLine("\nІнформація про магазини конвертована в файл!");
        }
    }
}
