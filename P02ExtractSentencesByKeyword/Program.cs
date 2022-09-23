using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02ExtractSentencesByKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchWord = Console.ReadLine();

            string pattern = $@"\b{searchWord}\b";

            Regex regex = new Regex(pattern);

            string[] sentences = Console.ReadLine()
                .Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            foreach (string sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence);
                }
            }

        }
    }
}
