using System;
using System.Text.RegularExpressions;

namespace P05MatchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbersAsString = Console.ReadLine();

            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numbers = Regex.Matches(numbersAsString, pattern);

            foreach (Match num in numbers)
            {
                Console.Write(num.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
