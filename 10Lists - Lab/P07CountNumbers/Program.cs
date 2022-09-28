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

            numbers.Sort();

            int count = 1;
            int curr = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (curr == numbers[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{curr} -> {count}");
                    count = 1;
                    curr = numbers[i];
                }
            }
            Console.WriteLine($"{curr} -> {count}");

        }
    }
}
