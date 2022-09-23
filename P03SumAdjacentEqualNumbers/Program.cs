using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace P00Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int index = 0;
            while (index < nums.Count - 1)
            {
                if (nums[index] == nums[index + 1])
                {
                    nums[index] *= 2;
                    nums.RemoveAt(index + 1);

                    if (index > 0)
                    {
                        index--;
                    }
                }
                else
                {
                    index++;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
