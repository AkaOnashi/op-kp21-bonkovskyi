using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace BuyersGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            //encoding to Ukrainian letters
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            bool flag = true;
            int choice = 0;
            Console.WriteLine("Привіт!\nВітаю в програмі \"Довідник покупця\"");
            while (flag)
            {
                Console.WriteLine("\nОсь чим наш довідник може допомогти: \n 1 - Додати магазин.\n 2 - Подивитися інформацію про всі магазини.\n 3 - Знайти магазин.\n 4 - Видалити магазин.\n 5 - Конвертувати інформацію у файл.\n 6 - Припинити програму.");
                Console.Write("Обери номер опції: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Введено некоректне значення. Будь ласка, введіть число.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ShopOperations.AddShop();
                        break;
                    case 2:
                        ShopOperations.PrintAllShopsInfo();
                        break;
                    case 3:
                        ShopOperations.FindShop();
                        break;
                    case 4:
                        ShopOperations.DeleteShop();
                        break;
                    case 5:
                        ShopOperations.ConvertToCSV();
                        break;
                    case 6:
                        Console.WriteLine("\nРобота програми призупинена.");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Введено некоректний номер опції. Будь ласка, спробуйте знову.");
                        break;
                }
            }
        }
    }
}
