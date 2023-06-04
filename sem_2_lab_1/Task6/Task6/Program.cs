using System;
using System.Buffers.Text;
using System.IO;
using static System.Formats.Asn1.AsnWriter;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a CSV file that is specified in Task 4, Create a binary file that is based on the CSV file.Read the binary file
            // and create another binary file that will contain the number of the students whose score is greater than 95 and all the records for those students.

            //test cases
            //Input: csv file "Students.csv" that contains 12 students with their scores
            //Output: 2 binary files: first contain list of students and scores; second contains list of students whose score is more than 95
            //or "There are not students whose score is more than 95"

            //read data from csv file
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Students.csv");
            string students = sr.ReadToEnd();
            sr.Close();

            //write data in the binary file
            BinaryWriter bw = new BinaryWriter(new FileStream("text.bin", FileMode.OpenOrCreate));
            bw.Write(students);
            bw.Close();

            //read the binary file
            BinaryReader br = new BinaryReader(new FileStream("text.bin", FileMode.Open));
            string students1 = br.ReadString();
            br.Close();

            //creating of binary file that contain students whose score is greater than 95
            BinaryWriter bw1 = new BinaryWriter(new FileStream("new_text.bin", FileMode.OpenOrCreate));
            string[] stud = students1.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            string[,] arr = new string[12, 3];
            int a = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = stud[a];
                    a++;
                }
            }

            // find student with score >95
            //display this student on the screen
            string stud_more = "";
            for (int i = 0; i < 12; i++)
            {
                int b = Int32.Parse(arr[i, 2]);
                if (b > 95)
                {
                    stud_more += arr[i, 0] + arr[i, 1];
                }
            }
            if (stud_more == "")
                Console.WriteLine("There are not students whose score is more than 95");

            bw1.Write(stud_more);
            bw1.Close();
        }
    }
}
