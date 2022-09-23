using System;
using System.Linq;
using System.Text;

namespace P03UnicodeCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine();

            var chars = word
                .Select(c => (int)c)
                .Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);

            Console.WriteLine(result);
                        
        }
    }
}
