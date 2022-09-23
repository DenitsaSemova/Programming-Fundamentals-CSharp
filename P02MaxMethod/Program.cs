using System;

namespace P02MaxMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            max = GetMax(thirdNumber, max);

            Console.WriteLine(max);
        }

        static int GetMax(int a, int b)
        {
            int max = 0;

            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            return max;
        }
    }
}
