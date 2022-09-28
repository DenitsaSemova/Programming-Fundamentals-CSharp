using System;
using System.Linq;

namespace P11EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int totalSum = 0;
            foreach (int number in numbers)
            {
                totalSum += number;
            }

            int leftSum = 0;
            int rightSum = totalSum;

            bool hasFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                rightSum -= currNum;

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    hasFound = true;
                    break;
                }

                leftSum += currNum;
            }

            if (hasFound == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
