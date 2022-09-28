using System;
using System.Collections.Generic;
using System.Linq;

namespace P01RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> positive = new List<int>();
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= 0)
                {
                    positive.Add(list[i]);
                }
            }

            positive.Reverse();

            if (positive.Count == 0)
            {
                Console.WriteLine("empty");
            }


            Console.WriteLine(String.Join(" ", positive));
        }
    }
}
