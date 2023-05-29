using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vectora = { 0, 2, 4, -5, 6, 8.23, -34, -2, 0, 2};
        double[] vectorb = { 1, 0, 6, 4, -24, 3.3, -2, 0 };

        double sumVect = Vector.SumNegElements(vectora, vectorb);
        Console.WriteLine(sumVect);

        double prod = Vector.ProdTwinEl(vectora, vectorb);
        Console.WriteLine(prod);

        int count = Vector.CountZeroElem(vectora, vectorb);
        Console.WriteLine(count);

        sumVect = Vector.SumNegElements(vectora);
        prod = Vector.ProdTwinEl(vectorb);
        count = Vector.CountZeroElem(vectora);

        Console.WriteLine(sumVect);
        Console.WriteLine(prod);
        Console.WriteLine(count);
    }
}

public class Vector
{
    public static double SumNegElements()
    {
        return 0;
    }
    public static double SumNegElements(double[] vectora)
    {
        double sum = 0;

        foreach (double el in vectora)
        {
            if (el < 0)
                sum += el;
        }

        return sum;
    }
    public static double SumNegElements(double[] vectora, double[] vectorb)
    {
        double sum = 0;
        
        foreach(double el in vectora)
        {
            if(el < 0)
                sum += el;
        }

        foreach (double el in vectorb)
        {
            if (el < 0)
                sum += el;
        }

        return sum;
    }
    public static double ProdTwinEl()
    {
        return 0;
    }
    public static double ProdTwinEl(double[] vectora)
    {
        double prod = 1;

        for (int i = 0; i < vectora.Length; i += 2)
        {
            prod *= vectora[i];
        }

        return prod;
    }
    public static double ProdTwinEl(double[] vectora, double[] vectorb)
    {
        double prod = 1;

        for(int i = 0; i < vectora.Length; i += 2)
        {
            prod *= vectora[i];
        }

        for (int i = 0; i < vectorb.Length; i += 2)
        {
            prod *= vectorb[i];
        }

        return prod;
    }
    public static int CountZeroElem()
    {
        return 0;
    }
    public static int CountZeroElem(double[] vectora)
    {
        int count = 0;

        foreach (double el in vectora)
        {
            if (el == 0)
                count++;
        }

        return count;
    }
    public static int CountZeroElem(double[] vectora, double[] vectorb)
    {
        int count = 0;
        
        foreach(double el in vectora)
        {
            if(el == 0)
                count++;
        }

        foreach (double el in vectorb)
        {
            if (el == 0)
                count++;
        }

        return count;
    }
}