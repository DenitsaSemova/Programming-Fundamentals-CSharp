using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03MatchHexadecimalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalNums = Console.ReadLine();

            string pattern = @"\b(0x)?[0-9A-F]+\b";

            var validNums = Regex.Matches(hexadecimalNums, pattern)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", validNums));
                       

        }
    }
}
