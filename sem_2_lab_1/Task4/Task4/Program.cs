using System;
using System.IO;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.WebRequestMethods;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //The text file contains the names and surnames of the students and their scores in CSV format.
            //Display all students whose score is less than 60 points.If such students are absent, display a message on the screen.

            try
            {

                using (StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Students.csv"))
                {
                            //test cases
                        //Input: file with studnets: name, last name, score
                        //Output: students whom score is less than 60. So in console we have to see the next:
                                // Students whose score is less than 60 points:
                            //First Name 1  Last Name 1
                            //First Name 4  Last Name 4
                            //First Name 5  Last Name 5
                            //First Name 8  Last Name 8
                            //First Name 11  Last Name 11

                    //convert data from file into array
                    string students = sr.ReadToEnd();

                    // find student with score <60

                    //dasplay this student on the screen
                    string[] stud_less = new string[students.Length];
                    
                }
            }

            catch
            {
                Console.WriteLine("Some problems here!");
            }
        }
    }
}