using System;
using System.Collections.Generic;
using System.Linq;

namespace P04Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();

            Console.WriteLine(String.Join(" ", nums.OrderByDescending(x => x).Take(3)));
        }
    }
}
