using System;
using System.Linq;

namespace P10PairsByDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input            
            //diff between each number in array
            //compare result with given number
            //print output

            int[] arr = Console.ReadLine()  // 1 5 3 4 2
                .Split()
                .Select(int.Parse)
                .ToArray();

            int difference = int.Parse(Console.ReadLine()); // 2
                        
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == difference)
                    {
                        counter++;

                    }

                }           
            }

            Console.WriteLine(counter);
           
        }
    }
}
