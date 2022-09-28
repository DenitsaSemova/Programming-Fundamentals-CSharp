using System;
using System.Collections.Generic;
using System.Linq;

namespace P06SumReversedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();

            // 123 234 12

            List<int> result = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                string eachElement = nums[i];
                char[] element = eachElement.ToCharArray();
                char[] reversed = element.Reverse().ToArray();
                result.Add(int.Parse(string.Join("", reversed)));

            }
            Console.WriteLine(result.Sum());
                        
        }
    }
}
