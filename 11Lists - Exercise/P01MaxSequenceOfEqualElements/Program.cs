using System;
using System.Collections.Generic;
using System.Linq;

namespace P01MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxNumber = 0;
            int maxCounter = 0;

            foreach (var num1 in nums)
            {
                int counter = 0;

                foreach (var num2 in nums)
                {
                    if (num1 == num2)
                    {
                        counter++;
                    }
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    maxNumber = num1;
                }
            }
            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write($"{maxNumber} ");
            }
        }
    }
}
