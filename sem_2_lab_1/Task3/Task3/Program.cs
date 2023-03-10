using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // The text file contains arbitrary English words, 1 word per line, no more than 40 words in the file,
            // the word length is limited to 80 characters.Rewrite words to another file by sorting them alphabetically.

            try
            {
                //new file & put down words in it
                //using (StreamWriter sw = new StreamWriter("EngWords.txt"))
                //{

                //}

                //// some cycle for sorting alphabetically
                //for ()
                //{

                //}

                ////rewritten file for sorted words
                //using (StreamWriter sw = new StreamWriter("SortedEngWords.txt"))
                //{

                //}
               
                for(int i = 0; i < 10; i++)
                {
                    string[] a = WordGenerator();
                    foreach (string s in a)
                    {
                        Console.Write(s);
                    }

                    Console.Write(" ");
                }
            }

            catch
            {
                Console.WriteLine("smth went wrong :(");
            }

        }

        //method that will make random word
        public static string[] WordGenerator()
        {
            //arrays for letters 
            string[] vow = "a e i o u y".Split(' ');
            string[] cons = "q w r t p s d f g h j k l z x c v b n m".Split(' ');


            Random rnd = new Random();
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rnd3 = new Random();

            int word_length = rnd1.Next(2, 10);
            string[] word1 = new string[word_length];

            for (int i = 0; i < word_length; i++)
            {
                int vowrnd = rnd.Next(0, 2);
                if (vowrnd == 0)
                {
                    int v_pos = rnd2.Next(0, vow.Length);
                    word1[i] = vow[v_pos];
                }
                else
                {
                    int c_pos = rnd3.Next(0, cons.Length);
                    word1[i] = cons[c_pos];
                }
            }

            //foreach (string word in word1)
            //{
            //    Console.Write(word);
            //}
            //Console.Write(" ");
            return word1;
        }

    }
}