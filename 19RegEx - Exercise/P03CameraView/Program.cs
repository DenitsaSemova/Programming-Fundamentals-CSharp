using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03CameraView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\|<(?<picture>\w+)");

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int skipNum = numbers[0];
            int takeNum = numbers[1];

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            string[] allResults = new string[matches.Count];
            int index = 0;
            foreach (Match match in matches)
            {
                string currMatch = match.Groups["picture"].Value;

                char[] resultChars = currMatch.Skip(skipNum)
                    .Take(takeNum)
                    .ToArray();

                string currResult = string.Join("", resultChars);

                allResults[index++] = currResult;
            }

            Console.WriteLine(string.Join(", ", allResults));
        }
    }
}
