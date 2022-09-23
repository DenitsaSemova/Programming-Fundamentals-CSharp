using System;
using System.Text.RegularExpressions;

namespace P04MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datesAsString = Console.ReadLine();

            string pattern = @"\b(\d{2})([-.\/])([A-Z][a-z]{2})(\2)(\d{4})\b";

            var dates = Regex.Matches(datesAsString, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups[1].Value;
                var month = date.Groups[3].Value;
                var year = date.Groups[5].Value;
                
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
