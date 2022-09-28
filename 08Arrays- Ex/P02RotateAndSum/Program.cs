using System;
using System.Linq;

namespace P02RotateAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine()); 

            int[] sumArray = new int[arr.Length];

            for (int i = 0; i < rotations; i++)
            {
                Shift(arr);

                Sum(sumArray, arr);
            }

            Console.WriteLine(String.Join(" ", sumArray));
        }

        static void Sum(int[] sumArray, int[] arr)
        {
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] += arr[i];
            }            
        }

        static void Shift(int[] arr)
        {
            int last = arr[arr.Length - 1];

            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = last;
        }


        // static void Main(string[] args)
        //{

        //int[] arr = ParseArray(Console.ReadLine());
        //Console.WriteLine();

        //}

        //static int[] ParseArray(string input)
        //{
        //    string[] tokens = input.Split();
        //    int[] result = new int[tokens.Length];

        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        result[i] = int.Parse(tokens[i]);
        //    }

        //    return result;
        //}
    }
}
