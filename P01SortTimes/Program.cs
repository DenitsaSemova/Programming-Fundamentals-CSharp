using System;
using System.Collections.Generic;
using System.Linq;

namespace P01SortTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> time = Console.ReadLine().Split().OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ", time));
        }
    }
}
