using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to create a text file that contains 2 lines. The content of the file should be displayed on the screen
            Console.WriteLine("Enter the first line of text:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter the second line of text:");
            string text1 = Console.ReadLine();
            text += "\n" + text1;

            using (FileStream fs = new FileStream("info.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fs.Write(array, 0, array.Length);
            }

            using (FileStream fs1 = File.OpenRead("info.txt"))
            {
                byte[] array = new byte[fs1.Length];
                fs1.Read(array, 0, array.Length);
                text = System.Text.Encoding.Default.GetString(array);

                Console.WriteLine();
                foreach(char el in array)
                    Console.Write(el);
            }
        }
    }
}
