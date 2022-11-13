using System;

class Task1
{
    static void Main(string[] args)
    {
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

        Console.WriteLine("The result is:");
        for (int i = 0; i < n; i++)
        {
            x = x_0 + i * (x_n - x_0) / n;
            y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
            Console.WriteLine("x = {0};  y = {1}; ", Math.Round(x, 2), Math.Round(y, 2));
        }
    }
}