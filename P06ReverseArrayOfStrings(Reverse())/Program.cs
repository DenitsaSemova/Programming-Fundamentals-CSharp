using System;
using System.Linq;

namespace P06ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Split(' ').ToArray();

            
            Console.WriteLine(string.Join(" ", arrStr.Reverse()));


        }
    }
}
