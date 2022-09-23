using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = Console.ReadLine();

            string pattern = @"(^| )\+359{1}( |-)2{1}(\2)\d{3}(\2)\d{4}\b";

            MatchCollection phoneMatches = Regex.Matches(phoneNumber, pattern);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
