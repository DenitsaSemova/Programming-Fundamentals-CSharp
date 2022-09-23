using System;
using System.Globalization;

namespace P01DayOfWeek_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture); // 18-04-2016

            Console.WriteLine(date.ToString("dddd"));
        }
    }
}
 