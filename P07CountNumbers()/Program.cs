using System;
using System.Collections.Generic;
using System.Linq;

namespace P07CountNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] counter = new int[1001];

            for (int i = 1; i < numbers.Count; i++)
            {
                int index = numbers[i];
                counter[index]++;
            }

            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counter[i]}");
                }
            }
        }
    }
}
