using System;
using System.Collections.Generic;
using System.Linq;

namespace P03Sum_Min_Max_Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNums = int.Parse(Console.ReadLine());

            //int nums = int.Parse(Console.ReadLine());

            List<int> result = new List<int>();

            for (int i = 0; i < countNums; i++)
            {
               int nums = int.Parse(Console.ReadLine());

                result.Add(nums);
            }

           
            Console.WriteLine($"Sum = {result.Sum()}");
            Console.WriteLine($"Min = {result.Min()}");
            Console.WriteLine($"Max = {result.Max()}");
            Console.WriteLine($"Average = {result.Average()}");
        }
    }
}
