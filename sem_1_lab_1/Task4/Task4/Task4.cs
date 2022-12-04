using System;

using System;

class Task4
{
    const double eps = 1e-15;
    static void Main(string[] args)
    {
        /*
         1: x = 0
         2: x = 1
         3: x = 10
         4: x = 5
         5: x = 44
         6: x = 675
         7: x = -7
         8: x = 24
         9: x = 3
        10: x = 25
         */

        double x, n = 1, sin_x = 0;
        Console.Write("Enter the value for x: ");
        x = Convert.ToDouble(Console.ReadLine());
        double a = x; // перший ряд 
        double b = a;

        while (b > eps)
        {
            sin_x = sin_x + a;
            n = n + 2; // збільшення показника
            a = -a * x * x / (n * (n - 1)); // додавання ряду
            if (a < 0)
            {
                b = -a;
            }
        }
        Console.WriteLine("sin_x = " + sin_x);
        Console.WriteLine("The table value for sin_x = " + Math.Sin(x));

        /*
         Табличні значення синусу
         1: sin_x = 0
         2: sin_x = 0.84
         3: sin_ = -0.54
         4: sin_ = -0.96
         5: sin_ = 0.02
         6: sin_ = 0.43
         7: sin_ = -0.66
         8: sin_ = -0.91
         9: sin_ = 0.14
        10: sin_ = -0.13
         */
    }
}