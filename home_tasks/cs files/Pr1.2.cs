using System;
class Tasks
{
    static void Main(string[] args)
    {
        double p, s; // p - напівпериметр, s - площа
        double a, b, c; // три сторони

        Console.Write("Сторона a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Сторона b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Сторона c = ");
        c = double.Parse(Console.ReadLine());

        p = (a + b + c) / 2;
        s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        Console.WriteLine("Площа = " + s);
    }
}
