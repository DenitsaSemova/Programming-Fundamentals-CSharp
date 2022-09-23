using System;
using System.Linq;

namespace P06MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int longestSeq = 0;
            int counter = 0;
            int endIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    counter++;

                }
                else
                {
                    if (counter > longestSeq)
                    {
                        longestSeq = counter;
                        endIndex = i - 1;
                    }
                    counter = 0;
                }

                if (i == arr.Length - 1)
                {
                    if (counter > longestSeq)
                    {
                        longestSeq = counter;
                        endIndex = i;
                    }
                }

            }

            for (int i = endIndex - longestSeq; i <= endIndex; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

    }
}
