using System;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            string debitCardNumber = $"{firstNum:d4} {secondNum:d4} {thirdNum:d4} {fourthNum:d4}";

            Console.WriteLine(debitCardNumber);

        }
    }
}
