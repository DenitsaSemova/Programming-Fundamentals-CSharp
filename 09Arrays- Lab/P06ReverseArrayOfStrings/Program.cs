using System;
using System.Linq;

namespace P06ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < arrStr.Length / 2; i++)
            {
                string temp = arrStr[i];
                arrStr[i] = arrStr[arrStr.Length - 1 - i];
                arrStr[arrStr.Length - 1 - i] = temp;
            }


            Console.WriteLine(string.Join(" ", arrStr));


        }
    }
}
