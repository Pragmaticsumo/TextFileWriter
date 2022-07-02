using System;
using System.IO;

namespace TextFileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create A File Name: ");
            string fileName = Console.ReadLine();

            if (File.Exists("TextFiles\\" + fileName + ".txt")) ;
            {
                File.Delete("TextFiles\\" + fileName + ".txt");
            }

            using FileStream fs = File.Create("TextFiles\\" + fileName + ".txt");
            using var sr = new StreamWriter(fs);


            Console.Clear();
            Console.WriteLine("Create File Contents: ");
            string fileContents = Console.ReadLine();

            sr.WriteLine(fileContents);
        }
    }
}
