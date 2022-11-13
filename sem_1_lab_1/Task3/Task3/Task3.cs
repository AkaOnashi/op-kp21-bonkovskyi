using System;

class Task3
{
    static void Main(string[] args)
    {
        //	Написати програму для обчислення факторіалу числа n та значення x^n.
        int n, x, fact_n = 1, x_n;
        Console.Write("Enter the value for n: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value for x: ");
        x = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            fact_n = fact_n * i;
        }
        Console.WriteLine("The factorial of " + n + " is equal to " + fact_n);

        x_n = (int)Math.Pow(x, n);
        Console.WriteLine("The x to the nth power is equal to " + x_n);

    }
}
