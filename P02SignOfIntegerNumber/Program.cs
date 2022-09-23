using System;

namespace P02.SignOfIntegerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string result = GetNumberSign(input);
            Console.WriteLine($"The number {input} is {result}.");
        }

        static string GetNumberSign(int num)
        {
            string result = "";

            if (num > 0)
            {
                result = "positive";
            }
            else if (num <0)
            {
                result = "negative";
            }
            else if (num == 0)
            {
                result = "zero";
            }

            return result;
        }
    }
}
