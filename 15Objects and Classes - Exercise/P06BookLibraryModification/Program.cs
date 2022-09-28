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

            DateTime filterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            List<Book> filteredBooks = books
                .Where(b => b.ReleaseDate > filterDate)
                .OrderBy(b => b.ReleaseDate)
                .ThenBy(b => b.Title)
                .ToList();

            foreach (Book book in filteredBooks)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }

            //ili mojem da go printirame na edin red

            //books.Where(b => b.ReleaseDate > filterDate)
            //    .OrderBy(b => b.ReleaseDate)
            //    .ThenBy(b => b.Title)
            //    .Select(b => $"{b.Title} -> {b.ReleaseDate:dd.MM.yyyy}")
            //    .ToList()
            //    .ForEach(Console.WriteLine);

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
