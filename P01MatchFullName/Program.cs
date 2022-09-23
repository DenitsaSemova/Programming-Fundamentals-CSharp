using System;
using System.Text.RegularExpressions;

namespace P01MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b([A-Z][a-z]+)\s([A-Z][a-z]+)\b";

            var matches = Regex.Matches(names, pattern);

            foreach (Match name in matches)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
