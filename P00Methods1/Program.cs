using System;

namespace P00Methods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            PrintNumbers(start, end);
        }

        static void PrintNumbers(int start, int end)
        {
            
            int first = Math.Min(start, end);
            int last = Math.Max(start, end);

            for (int i = first; i <= last; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
