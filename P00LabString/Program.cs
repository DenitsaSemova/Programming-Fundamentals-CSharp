using System;
using System.Linq;

namespace P00LabString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "ababa caba";
            string pattern = "aba";

            int count = 0;

            for (int i = 0; i <= input.Length - pattern.Length; i++)            
            {
                char[] subString = input
                    .Skip(i)
                    .Take(pattern.Length)
                    .ToArray();

                string toCheck = new string(subString);

                bool isEqual = String.Equals(pattern, toCheck);
                if (isEqual)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
