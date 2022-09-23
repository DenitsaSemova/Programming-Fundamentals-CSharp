using System;

namespace P11._5DifferentNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum - firstNum < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = firstNum; i <= secondNum; i++)
                {
                    for (int j = firstNum; j <= secondNum; j++)
                    {
                        for (int k = firstNum; k <= secondNum; k++)
                        {
                            for (int l = firstNum; l <= secondNum; l++)
                            {
                                for (int m = firstNum; m <= secondNum; m++)
                                {

                                    bool isValid = firstNum <= i && i < j && j < k && k < l && l < m && m <= secondNum;

                                    if (isValid)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {l} {m}");

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
