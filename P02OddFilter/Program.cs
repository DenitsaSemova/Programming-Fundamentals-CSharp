using System;
using System.Collections.Generic;
using System.Linq;

namespace P02OddFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> oddNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    oddNums.Add(nums[i]);
                }
            }

            int sum = 0;

            for (int i = 0; i < oddNums.Count; i++)
            {
                sum += oddNums[i];
            }

            int average = sum / oddNums.Count;

            for (int i = 0; i < oddNums.Count; i++)
            {
                if (oddNums[i] > average)
                {
                    oddNums[i] += 1;
                }
                else if (oddNums[i] < average)
                {
                    oddNums[i] -= 1;
                }
            }

            Console.WriteLine(string.Join(" ", oddNums));
        }
    }
}
