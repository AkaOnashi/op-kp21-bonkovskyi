using System;

class Task2
{
    static void Main(string[] args)
    {
        /*
         test cases
        1: n = 2
        2: n = 6
        3: n = 13
        4: n = 0
         */

        int n; 
        Console.WriteLine("This program checks if the number n is a prime.");
        Console.Write("Enter the value for n: ");
        n = Convert.ToInt32(Console.ReadLine());
        bool flag = true;
        if(n >= 2)
        {
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("The " + n + " is not the prime number");
                    flag = false;
                    break;
                }
                if (flag == true)
                {
                    Console.WriteLine("The " + n + " is the prime number");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("The " + n + " is not the prime number");
        }
        
        
        
        /*
         1: "n is the prime number"
         2: "n is not the prime number"
         3: "n is the prime number"
         4: "n is not the prime number"
        
         */


    }
}