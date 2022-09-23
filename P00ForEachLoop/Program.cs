using System;
using System.Linq;

namespace P00ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300 };

            foreach (int number in arr)
            {
                Console.WriteLine(number);
            }
        }
    }
}
