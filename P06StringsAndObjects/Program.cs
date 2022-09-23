using System;

namespace P06StringsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "Hello";
            string input2 = "World";

            object result = input1 + " " + input2;
            string output = Convert.ToString(result);

            Console.WriteLine(output);
        }
    }
}
