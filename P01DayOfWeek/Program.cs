using System;

namespace P01DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            // може да се направи и с готов метод
            // DayOfWeek[] daysOfWeek = new DayOfWeek[7];

            int day = int.Parse(Console.ReadLine());

            if (day > 7 || day < 1)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }
        }
    }
}
