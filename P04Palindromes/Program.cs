using System;
using System.Collections.Generic;
using System.Linq;

namespace P04Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(".,!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();
            foreach (var word in words)
            {
                bool isPalindrom = IsPalindrome(word);

                if (isPalindrom)
                {
                    palindromes.Add(word);
                }

            }

            var sorted = palindromes.Distinct().OrderBy(w => w);

            Console.WriteLine(String.Join(", ", sorted));
        }

        static bool IsPalindrome(string word)
        {
            string reversed = new string(word.Reverse().ToArray());            
            return String.Equals(reversed, word);
        }
    }
}
