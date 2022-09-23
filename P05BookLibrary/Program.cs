using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P05BookLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string title = tokens[0];
                string autor = tokens[1];
                string publisher = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = tokens[4];
                decimal price = decimal.Parse(tokens[5]);

                Book book = new Book(title, autor, publisher, releaseDate, isbn, price);

                books.Add(book);
            }

            Dictionary<string, decimal> autors = new Dictionary<string, decimal>();

            foreach (Book book in books)
            {
                string autorName = book.Autor;
                decimal price = book.Price;

                if (autors.ContainsKey(autorName) == false)
                {
                    autors.Add(autorName, price);
                }
                else
                {
                    autors[autorName] += price;
                }
            }

            Dictionary<string, decimal> sortedAutors = autors
                .OrderByDescending(a => a.Value)
                .ThenBy(a => a.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var autor in sortedAutors)
            {
                Console.WriteLine($"{autor.Key} -> {autor.Value:f2}");
            }

        }
    }

    class Book
    {
        public Book(string title, string autor, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            this.Title = title;
            this.Autor = autor;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.Isbn = isbn;
            this.Price = price;
        }

        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }

    }
}
