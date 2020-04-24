using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShelf.db.DataBaseConnection;
using BookShelf.db.Entities;

namespace BookShelf.db.Query
{
    class QueryManager
    {
        private SQLCon SQLCon;
        private LinkedList<Book> booksList;
        private LinkedList<Magazine> magazineList;
        private NpgsqlCommand sqlCommand;

        public QueryManager(SQLCon sQL)
        {
            SQLCon = sQL;
        }

        public LinkedList<Book> SelectAllBooks()
        {
            string sq = "SELECT author, name, pages, year, price, genre FROM \"Publication\" as t1 join \"Book\" as t2 on t1.id = t2.id;";
            booksList = new LinkedList<Book>();
            NpgsqlCommand sqlCommand = new NpgsqlCommand(sq, SQLCon.GetNpgsqlConnection());
            NpgsqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var book = new Book(
                    reader.GetString(0), 
                    reader.GetString(1), 
                    reader.GetInt32(2), 
                    reader.GetInt32(3), 
                    reader.GetFloat(4),
                    reader.GetString(5));
                booksList.AddLast(book);
                //MessageBox.Show(book.ToString());
            }
            reader.Close();
            return booksList;
        }

        public LinkedList<Magazine> SelectAllMagazines()
        {
            string sqlText = "SELECT author, name, pages, year, price, frequency, number  FROM \"Publication\" as t1 join \"Magazine\" as t2 on t1.id = t2.id;";
            magazineList = new LinkedList<Magazine>();
            NpgsqlCommand sqlCommand = new NpgsqlCommand(sqlText, SQLCon.GetNpgsqlConnection());
            NpgsqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var magazine = new Magazine(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetFloat(4),
                    reader.GetInt32(5),
                    reader.GetInt32(6));
                magazineList.AddLast(magazine);
                //MessageBox.Show(magazine.ToString());
            }
            reader.Close();
            return magazineList;
        }
        public void clearTables()
        {
            string[] tables = new string[] { "\"Publication\"", "\"Book\"", "\"Magazine\"" };

            foreach (string table in tables)
            {
                string query = "TRUNCATE TABLE " + table;
                NpgsqlCommand SqlCommand = new NpgsqlCommand(query, SQLCon.GetNpgsqlConnection());
                NpgsqlDataReader rr = SqlCommand.ExecuteReader();
                rr.Close();
            }
        }

        public void Insert(Book book)
        {
            string[] queries = new string[] {
                String.Format("insert into \"Publication\" (id, author, name, year, pages, price) values({0}, '{1}', '{2}', {3}, {4}, {5});", book.id, book.author, book.name, book.year, book.numberOfPages, book.price.ToString().Replace(',', '.')),
                String.Format("insert into \"Book\"(id, genre) values({0}, '{1}');", book.id, book.genre)};

            foreach (var query in queries)
            {
                sqlCommand = new NpgsqlCommand(query, SQLCon.GetNpgsqlConnection());
                NpgsqlDataReader rr = sqlCommand.ExecuteReader();
                rr.Close();
            }
        }

        public void Insert(Magazine magazine)
        {
            string[] queries = new string[] {
                String.Format("insert into \"Publication\" (id, author, name, year, pages, price) values({0}, '{1}', '{2}', {3}, {4}, {5});", magazine.id, magazine.author, magazine.name, magazine.year, magazine.numberOfPages, magazine.price.ToString().Replace(',', '.')),
                String.Format("insert into \"Magazine\"(id, number, frequency) values ({0}, {1}, {2});", magazine.id, magazine.number, magazine.frequency)};

            foreach (var query in queries)
            {
                sqlCommand = new NpgsqlCommand(query, SQLCon.GetNpgsqlConnection());
                NpgsqlDataReader rr = sqlCommand.ExecuteReader();
                rr.Close();
            }
        }

    }
}
