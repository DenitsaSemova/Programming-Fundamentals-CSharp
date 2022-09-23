using System;
using System.Linq;

namespace P09ExtractMiddleElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            if (arr.Length == 1)
            {
                GetMiddleOne(arr);
            }
            else if (arr.Length % 2 == 0)
            {
                GetMiddleTwo(arr);
            }
            else
            {
                GetMiddleThree(arr);
            }

        }

        static void GetMiddleThree(int[] arr)
        {
            Console.WriteLine($"{{ {arr[arr.Length / 2 - 1]},{arr[arr.Length / 2]},{arr[arr.Length / 2 + 1]} }}");
        }

        static void GetMiddleTwo(int[] arr)
        {
            Console.WriteLine($"{{ {arr[arr.Length / 2 - 1]}, {arr[arr.Length / 2]} }}");
        }

        static void GetMiddleOne(int[] arr)
        {
            Console.WriteLine($"{{ {arr[0]} }}");
        }
    }
}
