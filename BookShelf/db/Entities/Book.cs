using System;
using System.Collections.Generic;
using System.Text;

namespace BookShelf.db.Entities
{
    class Book : Publication 
    {
        public string genre { get; set; }

        public Book()
        {
            author = "";
            name = "";
            numberOfPages = 0;
            year = 0;
            price = 0;
            genre = "";
        }

        public Book(string author,
            string name,
            int numberOfPages,
            int year,
            double price,
            string genre): base(author, name, numberOfPages, year, price)
        {
            this.genre = genre;
        }

        public Book(Book other)
        {
            author = other.author;
            name = other.name;
            numberOfPages = other.numberOfPages;
            year = other.year;
            price = other.price;
            genre = other.genre;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + genre;
        }
    }
}
