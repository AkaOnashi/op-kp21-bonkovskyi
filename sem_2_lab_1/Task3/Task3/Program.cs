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
                using (StreamWriter sw = new StreamWriter("EngWords.txt"))
                {

                }

                // some cycle for sorting alphabetically
                for ()
                {

                }

                //rewritten file for sorted words
                using(StreamWriter sw = new StreamWriter("SortedEngWords.txt"))
                {

                }
            }
            catch
            {
                Console.WriteLine("smth went wrong :(");
            }

        }

        //method that will make random word
        public static void WordGenerator(string word)
        {
            
        }

    }
}