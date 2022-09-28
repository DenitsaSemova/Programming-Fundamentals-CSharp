using System;

namespace P08SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int i = 0;
            int sum = 0;
            int curr = 1;

            while (i < n)
            {
                Console.WriteLine(curr);
                sum += curr;
                curr += 2;
                i++;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
