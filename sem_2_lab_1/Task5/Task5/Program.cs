using System;
using System.IO;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that will calculate the number of each word in a text file.

            using(StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\text.txt"))
            {
                string words = sr.ReadToEnd();
                string[] words1 = words.Split(new string[] { " ", ".", ",", "!", "?", ";", ":", "-", "(", ")", "[", "]", "{", "}", "/", "\\", "\'", "\"" }, StringSplitOptions.RemoveEmptyEntries);
                int a = 0;

                Console.WriteLine(words1.Length);
            }

        }
    }
}
