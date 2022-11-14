using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            double e0, e1; // first value of energy and the last
            double now;

            Console.Write("Enter the first value of energy: ");
            e0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the last value of energy: ");
            e1 = Convert.ToDouble(Console.ReadLine());

            now = e1 - e0;
            if (now <= 250 && now > 0)
            {
                Console.WriteLine("The price is " + now * 1.44 + "grn");
            }
            else if (now > 250)
            {
                Console.WriteLine("The price is " + ((now - 250) * 1.68 + 250 * 1.44) + "grn");
            }
            else
            {
                Console.WriteLine("You`ve entered the wrong value");
            }

        }
    }

}