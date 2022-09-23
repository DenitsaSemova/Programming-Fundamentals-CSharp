using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace P02RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = random.Next(0, words.Length - 1);
                var curr = words[i];
                words[i] = words[index];
                words[index] = curr;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
