using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d; // four numbers
            Console.Write("Enter the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of d: ");
            d = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                if (a < c)
                {
                    if (a < d)
                    {
                        Console.WriteLine("The min is number a: " + a);
                    }
                    else
                    {
                        Console.WriteLine("The min is number d: " + d);
                    }
                }
                else
                {
                    if (c < b)
                    {
                        if (c < d)
                        {
                            Console.WriteLine("The min is number c: " + c);
                        }
                        else
                        {
                            Console.WriteLine("The min is number d: " + d);
                        }
                    }
                    else
                    {
                        if (b < d)
                        {
                            Console.WriteLine("The min is number b: " + b);
                        }
                        else
                        {
                            Console.WriteLine("The min is number a: " + a);
                        }
                    }
                }


            }
            else
            {
                if (b < c)
                {
                    if (b < d)
                    {
                        Console.WriteLine("The min is number b: " + b);
                    }
                    else
                    {
                        Console.WriteLine("The min is number d: " + d);
                    }
                }
                else
                {
                    if (c < d)
                    {
                        Console.WriteLine("The min is number c: " + c);
                    }
                    else
                    {
                        Console.WriteLine("The min is number d: " + d);
                    }
                }
            }

        }
    }

}
