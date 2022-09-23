using System;
using System.Linq;

namespace P02RotateAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // taka poluchavame chislata v masiva na otdelni redove

            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }

        }
    }
}
