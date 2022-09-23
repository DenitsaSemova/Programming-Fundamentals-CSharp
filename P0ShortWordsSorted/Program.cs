using System;
using System.Collections.Generic;
using System.Linq;

namespace P05ShortWordsSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' '};

            string[] words = Console.ReadLine().ToLower().Split(separators);

            words = words.Where(x => x != "").ToArray();
            words = words.Where(x => x.Length < 5).ToArray();
            words= words.OrderBy(x => x).Distinct().ToArray();

            Console.WriteLine(String.Join(", ", words));
        }
    }
}
