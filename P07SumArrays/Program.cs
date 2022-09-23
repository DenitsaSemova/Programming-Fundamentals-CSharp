using System;
using System.Linq;

namespace P07SumArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = Math.Max(arr1.Length, arr2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                int sum = 0;

                int firstValue = arr1[i % arr1.Length];
                int secondValue = arr2[i % arr2.Length];

                sum = firstValue + secondValue;

                Console.Write(sum + " ");
            }
        }
    }
}
