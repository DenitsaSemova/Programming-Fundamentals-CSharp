using System;

namespace P01OddLines
{
    using System.IO;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            ////D:\Denitsa\Programming\Programming-Fundamentals_June2022\23 Files and Exceptions\Resources\01. Odd Lines

            //string[] lines = File.ReadAllLines(@"D:\Denitsa\Programming\Programming-Fundamentals_June2022\23 Files and Exceptions\Resources\01. Odd Lines\Input.txt");

            //for (int i = 1; i < lines.Length; i+=2)
            //{
            //    Console.WriteLine(lines[i]);
            //}

            string[] lines = File.ReadAllLines("input.txt");

            var oddlines = lines.Where((line,i) => i % 2 == 0).ToArray();

            File.WriteAllLines("output.txt", oddlines);
        }
    }
}
