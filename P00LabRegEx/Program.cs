using System;
using System.Text.RegularExpressions;

namespace P00LabRegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] names = new string[]
            //{
            //    "IPvan Ivanov",
            //    "Ivan Ivanov",
            //    "PVesho Peshov"

            //};

            //string pattern = @"^[A-Z][a-z]+\s[A-Z][a-z]+$";

            //Regex regex = new Regex(pattern);

            //for (int i = 0; i < names.Length; i++)
            //{
            //    string name = names[i];

            //    //bool isMatch = regex.IsMatch(name);
            //    //Console.WriteLine(isMatch);

            //    Match match = regex.Match(name);

            //    if (match.Success)
            //    {
            //        Console.WriteLine(match);

            //    }
            //}
            
            
            string input = "IPvan Ivanov, Ivan Ivanov, PVesho Peshov, PEsho PeshoV";

            string pattern = @"\b([A-Z][a-z]+)\s(?<lastName>[A-Z][a-z]+)\b";

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches) //!!!!!!!!!! Match -> za da imame neshtata sled tochkata dolu
            {
                //Console.WriteLine(match.Groups[1]);
                Console.WriteLine(match.Groups["lastName"]);
            }
        }
    }
}
