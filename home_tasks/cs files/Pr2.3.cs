using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the number of the mounth: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 12:
                    Console.WriteLine("It's Winter!");
                    break;
                case 1:
                    Console.WriteLine("It's Winter!");
                    break;
                case 2:
                    Console.WriteLine("It's Winter!");
                    break;
                case 3:
                    Console.WriteLine("It's Spring!");
                    break;
                case 4:
                    Console.WriteLine("It's Spring!");
                    break;
                case 5:
                    Console.WriteLine("It's Spring!");
                    break;
                case 6:
                    Console.WriteLine("It's Summer!");
                    break;
                case 7:
                    Console.WriteLine("It's Summer!");
                    break;
                case 8:
                    Console.WriteLine("It's Summer!");
                    break;
                case 9:
                    Console.WriteLine("It's Fall!");
                    break;
                case 10:
                    Console.WriteLine("It's Fall!");
                    break;
                case 11:
                    Console.WriteLine("It's Fall!");
                    break;
                default:
                    Console.WriteLine("You've entered the wrong number");
                    break;
            }
        }
    }

}