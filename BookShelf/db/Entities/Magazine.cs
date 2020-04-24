using System;
using System.Collections.Generic;
using System.Text;

namespace BookShelf.db.Entities
{
    class Magazine : Publication
    {
        public int frequency { get; set; }
        public int number { get; set; }

        public Magazine()
        {
            author = "";
            name = "";
            numberOfPages = 0;
            year = 0;
            price = 0;
            frequency = 0;
            number = 0;

        }

        public Magazine(string author,
            string name,
            int numberOfPages,
            int year,
            double price,
            int frequency,
            int number) : base(author, name, numberOfPages, year, price)
        {
            this.frequency = frequency;
            this.number = number;
        }

        public Magazine(Magazine other)
        {
            author = other.author;
            name = other.name;
            numberOfPages = other.numberOfPages;
            year = other.year;
            price = other.price;
            frequency = other.frequency;
            number = other.number;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + frequency + ";" + number;
        }
    }
}