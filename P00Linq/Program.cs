using System;
using System.Linq;

namespace P00Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //samo primer. taka koda e nechetim!!!
            
            string input = "1 2 3";

            string[] arr = input.Split()
                .Select(int.Parse)
                .ToArray()
                .Select(x => ++x)
                .ToArray()
                .Select(x => x.ToString())
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");

            }
            
        }
    }
}
