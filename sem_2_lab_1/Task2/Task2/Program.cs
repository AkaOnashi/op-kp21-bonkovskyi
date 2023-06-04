using System;
using System.ComponentModel;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that allows you to create a text file and write to it 15 random
            // real numbers. The numbers should be on the same line. Find the maximum among them and write it into another file with the name max.txt

            Random random = new Random();
            double[] nums = new double[15];

            for (int i = 0; i < 15; i++)
            {
                nums[i] = random.Next(-1000, 1000);
            }

            using (StreamWriter fs = new StreamWriter("numbers.txt"))
            {
                foreach(double d in nums)
                {
                    fs.Write(d + " ");
                }
            }

            double max = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                if (max < nums[i])
                    max = nums[i];
            }

            using (StreamWriter fs = new StreamWriter("max.txt"))
            {
                fs.Write(max);
            }
        }
    }
}
