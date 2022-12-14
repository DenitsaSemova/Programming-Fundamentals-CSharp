using System;
using System.Collections.Generic;
using System.Linq;

namespace P05MagicExchangeableWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            char[] first = words[0].ToCharArray();
            char[] second = words[1].ToCharArray();

            var list1 = new List<char>();
            var list2 = new List<char>();

            for (int i = 0; i < first.Length; i++)
            {
                if (list1.Any(x => x == first[i]) == false)
                {
                    list1.Add(first[i]);
                }
            }

            for (int i = 0; i < second.Length; i++)
            {
                if (list2.Any(x => x == second[i]) == false)
                {
                    list2.Add(second[i]);
                }
            }

            if (list1.Count == list2.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
