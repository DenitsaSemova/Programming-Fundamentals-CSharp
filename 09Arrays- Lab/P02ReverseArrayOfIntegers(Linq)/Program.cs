using System;
using System.Linq;

namespace P02ReverseArrayOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5 };

            //  // Ako e nechetno ne trqbwa da obryshta srednoto 5 / 2 = 2. 
            //  // Pri chetno syshto raboti. 4 /2 = 2;
            //for (int i = 0; i < nums.Length / 2; i++)
            //{
            //    int temp = nums[i];
            //    nums[i] = nums[nums.Length - 1 - i];
            //    nums[nums.Length - 1 - i] = temp;
            //}

            //Console.WriteLine(String.Join(" ", nums));


            int count = int.Parse(Console.ReadLine());

            int[] arr = new int[count];

            for (int i = 0; i < count; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            arr = arr.Reverse().ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
                                
            }



            // vmesto wtoriq for cikul moje i samo s towa ->
            // Array.Reverse(arr);
            //Console.WriteLine(String.Join(" ", arr));

        }
    }
}
