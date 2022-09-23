using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P3NetherRealms_ExamPrep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternHealthPoints = @"[^0-9+\-*\/\.]";
            string patternDamage = @"(-)?\d+(\.\d+)*";

            string[] demons = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> sortedDemons = new List<string>();

            foreach (var demon in demons)
            {

                int totalHP = 0;
                foreach (Match match in Regex.Matches(demon, patternHealthPoints))
                {

                    if (match.Success)
                    {
                        totalHP += match.Value[0];
                    }
                }


                double totalDamage = 0;
                foreach (Match number in Regex.Matches(demon, patternDamage))
                {
                    if (number.Success)
                    {
                        totalDamage += double.Parse(number.Value);
                    }
                }

                var multiplication = demon.Where(x => x == '*').ToArray();
                var division = demon.Where(x => x == '/').ToArray();

                totalDamage = totalDamage * (Math.Pow(2, multiplication.Length));
                totalDamage = totalDamage / (Math.Pow(2, division.Length));

                string result = $"{demon} - {totalHP} health, {totalDamage:f2} damage ";

                sortedDemons.Add(result);
            }

            sortedDemons = sortedDemons.OrderBy(x => x).ToList();

            foreach (var d in sortedDemons)
            {
                Console.WriteLine(d);
            }
        }
    }
}
