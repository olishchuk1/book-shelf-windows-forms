using System;
using System.Collections.Generic;
using System.Text;

namespace BookShelf.db.Entities
{
    public abstract class Publication
    {
        public string author;
        public string name;
        public int numberOfPages;
        public int year;
        public double price;
        public int id;
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
        protected Publication(int id, 
            string author,
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
            this.id = id;
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
