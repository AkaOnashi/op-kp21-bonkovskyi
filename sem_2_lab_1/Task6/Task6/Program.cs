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

            //read data from csv file
            StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Students.csv");
            
            sr.Close();

            //write data in the binary file
            BinaryWriter bw = new BinaryWriter(new FileStream("text.bin", FileMode.OpenOrCreate));

            bw.Close();

            //read the binary file
            BinaryReader br = new BinaryReader(new FileStream("text.bin", FileMode.Open));

            br.Close();

            //creating of binary file that contain students whose score is greater than 95
            BinaryWriter bw1 = new BinaryWriter(new FileStream("new_text.bin", FileMode.OpenOrCreate));

            bw1.Close();
        }
    }
}
