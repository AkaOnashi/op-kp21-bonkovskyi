using System;

class Task3
{
    static void Main(string[] args)
    {
        /*
         test cases:
        1: x_0 = 2; x_n = 4; n = 3
        2: x_0 = 4; x_n = 6; n = 2
        3: x_0 = 3; x_n = 56; n = 4
         */

        double x_0, x_n, n;
        double x, y;
        double a = 1.35;
        double b = -6.25;
        Console.Write("Enter the value for x_0: ");
        x_0 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value for x_n: ");
        x_n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value for n: ");
        n = Convert.ToInt32(Console.ReadLine());

        /*
         1: x = 2,6; y = 10,81
            x = 3,3; y = 26,59
            x = 4; y = 50,59
         2: x = 4; y = 86,58
            x = 5; y = 169
         3: x = 3; y = 36,52
            x = 16,25; y = 5793,69
            x = 29,5; y = 34658,24
            x = 42,75; y = 105474,2
         */
        Console.WriteLine("The result is:");
        for (int i = 0; i < n; i++)
        {
            x = x_0 + i * (x_n - x_0) / n;
            y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
            Console.WriteLine("x = {0};  y = {1}; ", Math.Round(x, 2), Math.Round(y, 2));
        }
    }
}