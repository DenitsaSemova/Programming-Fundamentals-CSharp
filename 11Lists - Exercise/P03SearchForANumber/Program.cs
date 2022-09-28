using System;
using System.Collections.Generic;
using System.Linq;

namespace P03SearchForANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] manipulations = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

            int take = manipulations[0]; 
            int remove = manipulations[1]; 
            int searchedNum = manipulations[2];

            List<int> collection = new List<int>();

            for (int i = 0; i < take; i++)
            {
                collection.Add(nums[i]);
            }

            for (int i = 0; i < remove; i++)
            {
                collection.RemoveAt(0);
            }

            bool result = false;

            for (int i = 0; i < collection.Count; i++)
            {
                result = collection.Contains(searchedNum);
            }

            if (result)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

            
        }
    }
}
