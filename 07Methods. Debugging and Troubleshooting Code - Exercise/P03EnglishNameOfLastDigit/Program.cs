using System;

namespace P03EnglishNameOfLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            string lastDigitName = GetLastDigitName(number);
            Console.WriteLine(lastDigitName);
        }

        static string GetLastDigitName(long number)
        {
            number = Math.Abs(number);
            long digit = number % 10;

            string lastDigitName = "";

            switch (digit)
            {
                case 0:
                    lastDigitName = "zero";
                    break;
                case 1:
                    lastDigitName = "one";
                    break;
                case 2:
                    lastDigitName = "two";
                    break;
                case 3:
                    lastDigitName = "three";
                    break;
                case 4:
                    lastDigitName = "four";
                    break;
                case 5:
                    lastDigitName = "five";
                    break;
                case 6:
                    lastDigitName = "six";
                    break;
                case 7:
                    lastDigitName = "seven";
                    break;
                case 8:
                    lastDigitName = "eight";
                    break;
                case 9:
                    lastDigitName = "nine";
                    break;
                
            }

            return lastDigitName;
        }                
    }
}
