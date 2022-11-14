using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp; // temperature of water
            Console.Write("Enter the temperature of water: ");
            temp = Convert.ToDouble(Console.ReadLine());

            if (temp <= 0)
            {
                Console.WriteLine("Water is ice");
            }
            else
            {
                if (temp >= 100)
                {
                    Console.WriteLine("It's boiling water");
                }
                else
                {
                    Console.WriteLine("Water is liquid");
                }
            }
          
        }
    }

}