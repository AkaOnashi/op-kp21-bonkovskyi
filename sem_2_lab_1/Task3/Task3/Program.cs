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
                                //test cases
                            //Input: en empty file "EngWords.txt"
                            //Output: no more than 40 words, that made WordGeneraator, in the file "EngWords.txt"

                    Random random = new Random();
                    int word_num = random.Next(10, 40);
                    for (int i = 0; i < word_num; i++)
                    {
                        string[] word = WordGenerator();
                        foreach (string s in word)
                        {
                            sw.Write(s);
                        }
                        sw.WriteLine();
                    }

                }

                //read file with words and sort it
                using (StreamReader sw = new StreamReader("EngWords.txt"))
                {
                                //test cases
                            //Input: file "EngWords" with words
                            //Output: return sorted array words

                    string text = sw.ReadToEnd();
                    string[] words = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length - 1; i++)
                    {
                        for (int j = 0; j < words.Length - i - 1; j++)
                        {
                            if (string.Compare(words[j], words[j + 1]) > 0)
                            {
                                string temp = words[j];
                                words[j] = words[j + 1];
                                words[j + 1] = temp;
                            }
                        }
                    }

                    //rewritten file for sorted words
                    using (StreamWriter sw1 = new StreamWriter("SortedEngWords.txt"))
                    {
                        //test cases
                        //Input: sorted array words
                        //Output: written words in the file "SortedEngWords"

                        foreach (string word in words)
                        {
                            sw1.Write(word);
                        }

                    }

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


            return word1;
        }

    }
}