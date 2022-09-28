using System;
using System.Text.RegularExpressions;

namespace P01ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            string pattern = @"(?<= )[A-Za-z0-9]+([.\-_][A-Za-z0-9]+)*@[A-Za-z]+([\-A-Za-z]+)(\.[A-Za-z]+)+";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match email in matches)
            {
                Console.WriteLine(email);
            }
        }
    }
}
