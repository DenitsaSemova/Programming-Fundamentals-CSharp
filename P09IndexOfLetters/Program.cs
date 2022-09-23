using System;

namespace P09IndexOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();

            char[] alphabet = new char[26];

            int index = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[index++] = i;
            }

            foreach (char letter in word)
            {
                //Ima takuv metod, koito moje da se izpolzva vmesto IndexOf metoda, koito suzdavame
                //int foundIndex = Array.IndexOf(alphabet, letter);

                int foundIndex = IndexOf(alphabet, letter);

                Console.WriteLine($"{letter} -> {foundIndex}");
            }
        }

        static int IndexOf(char[] alphabet, char letter)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
