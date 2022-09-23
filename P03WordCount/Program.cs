using System;

namespace P03WordCount
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {

            string[] words = File
                .ReadAllText("words.txt")
                .ToLower()
                .Split();

            Dictionary<string, int> counts = words.ToDictionary(x => x, x => 0);

            string text = File.ReadAllText("text.txt")
                .ToLower();

            MatchCollection matches = Regex.Matches(text, @"[a-zA-Z][a-zA-Z0-9'`]*");

            foreach (Match match in matches)
            {
                if (counts.ContainsKey(match.Value))
                {
                    counts[match.Value]++;
                }
            }

            var output = new StringBuilder(words.Length);

            foreach (var item in counts.OrderByDescending(w => w.Value))
            {
                output.AppendLine($"{item.Key} -> {item.Value}");
            }

            File.WriteAllText("results.txt", output.ToString());

            //SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            //string inputWords = File.ReadAllText(@"D:\Denitsa\Programming\Programming-Fundamentals_June2022\23 Files and Exceptions\Resources\03. Word Count\words.txt");
            //string[] words = inputWords.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            //String pattern = @"[a-zA-Z']+";
            //Regex regex = new Regex(pattern);


            //using (var reader = new StreamReader(@"D:\Denitsa\Programming\Programming-Fundamentals_June2022\23 Files and Exceptions\Resources\03. Word Count\text.txt"))
            //{
            //    string currentSentcence = reader.ReadLine();

            //    while (currentSentcence != null)
            //    {

            //        foreach (Match match in regex.Matches(currentSentcence))
            //        {
            //            for (int i = 0; i < words.Length; i++)
            //            {

            //                if (match.Value.ToLower() == words[i] && !(dictionary.ContainsKey(words[i])))
            //                {
            //                    dictionary.Add(words[i], 1);
            //                }


            //                else if (match.Value.ToLower() == words[i])
            //                {
            //                    dictionary[words[i]]++;
            //                }

            //            }

            //        }
            //        currentSentcence = reader.ReadLine();
            //    }

            //    foreach (var item in dictionary.OrderByDescending(key => key.Value))
            //    {
            //        Console.WriteLine("{0} - {1}", item.Key, item.Value);
            //    }

            //}
        }
    }
}
