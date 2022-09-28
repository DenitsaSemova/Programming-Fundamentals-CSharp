using System;

namespace P02LineNumbers
{
    using System.Diagnostics.Tracing;
    using System.IO;
    using System.Linq;
    using System.Threading;

    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = File.ReadAllLines(@"D:\Denitsa\Programming\Programming-Fundamentals_June2022\23 Files and Exceptions\Resources\02. Line Numbers\Input.txt");

            //int counter = 1;
            //foreach (var line in lines)
            //{
            //    Console.WriteLine($"{counter}. {line}");

            //    counter++;
            //}

            string[] lines = File.ReadAllLines("input.txt");

            var numeric = lines
                .Select((line, index) => (index+1) + ". " + line)
                .ToArray();

            File.WriteAllLines("output.txt", numeric);

        }
    }
}
