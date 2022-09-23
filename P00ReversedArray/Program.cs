using System;

namespace P06ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.WriteLine(String.Join(" ", arr));

            //moje da se naprawi i taka
            
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //Array.Reverse(arr);

            //Console.WriteLine(String.Join(" ", arr));


        }
    }
}
