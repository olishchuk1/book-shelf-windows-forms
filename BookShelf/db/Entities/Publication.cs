using System;
using System.Collections.Generic;
using System.Text;

namespace BookShelf.db.Entities
{
    abstract class Publication
    {
        public string author { get; set; }
        public string name { get; set; }
        public int numberOfPages { get; set; }
        public int year { get; set; }
        public double price { get; set; }
        public int id { get; }
        static int counter = 1;
        protected Publication()
        {
            author = "";
            name = "";
            numberOfPages = 0;
            year = 0;
            price = 0.0;
        }

        protected Publication(string author,
            string name,
            int numberOfPages,
            int year,
            double price)
        {
            this.author = author;
            this.name = name;
            this.numberOfPages = numberOfPages;
            this.year = year;
            this.price = price;
            id = GenerateId();
        }

        protected Publication(Publication other)
        {
            author = other.author;
            name = other.name;
            numberOfPages = other.numberOfPages;
            year = other.year;
            price = other.price;
        }
        private int GenerateId()
        {
            return counter++;
        }

        public override string ToString()
        {
            return author + ";" + name + ";" + numberOfPages + ";" + year + ";" + price;
        }
    }
}
