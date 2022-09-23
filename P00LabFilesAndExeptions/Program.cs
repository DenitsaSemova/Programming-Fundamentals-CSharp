using System;

namespace P00LabFilesAndExeptions
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("TestFolder");
            //Directory.Delete("TestFolder", true); -> iztriva i vsichko v papkata



            //var files = Directory.GetFiles(".\\");
            ////var directories = Directory.GetDirectories("..\\"); -> wrushta papkite

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}



            string input = "1";

            try
            {
                int.Parse(input);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                throw new ArgumentException($"The input {input} was not correct!");
            }
            finally
            {
                Console.WriteLine($"Finally I made it! - said {input}");
            }
        }
    }
}
