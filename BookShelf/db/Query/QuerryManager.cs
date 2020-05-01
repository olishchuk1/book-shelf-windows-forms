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
        private List<Book> booksList;
        private List<Magazine> magazineList;
        private NpgsqlCommand sqlCommand;

        public QueryManager(SQLCon sQL)
        {
            SQLCon = sQL;
        }

        public List<Book> SelectAllBooks()
        {
            string sq = "SELECT t2.id, author, name, pages, year, price, genre FROM \"Publication\" as t1 join \"Book\" as t2 on t1.id = t2.id;";
            booksList = new List<Book>();
            NpgsqlCommand sqlCommand = new NpgsqlCommand(sq, SQLCon.GetNpgsqlConnection());
            NpgsqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var book = new Book(
                    reader.GetInt32(0),
                    reader.GetString(1), 
                    reader.GetString(2), 
                    reader.GetInt32(3), 
                    reader.GetInt32(4), 
                    reader.GetFloat(5),
                    reader.GetString(6));
                booksList.Add(book);
                //MessageBox.Show(book.ToString());
            }
            reader.Close();
            return booksList;
        }

        public List<Magazine> SelectAllMagazines()
        {
            string sqlText = "SELECT t2.id, author, name, pages, year, price, frequency, number  FROM \"Publication\" as t1 join \"Magazine\" as t2 on t1.id = t2.id;";
            magazineList = new List<Magazine>();
            NpgsqlCommand sqlCommand = new NpgsqlCommand(sqlText, SQLCon.GetNpgsqlConnection());
            NpgsqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var magazine = new Magazine(reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetInt32(3),
                    reader.GetInt32(4),
                    reader.GetFloat(5),
                    reader.GetInt32(6),
                    reader.GetInt32(7));
                magazineList.Add(magazine);
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

        public void Update(Book book)
        {
            string[] queries = new string[] {
                String.Format("UPDATE \"Publication\" SET author='{0}', name='{1}', year={2}, pages={3}, price={4} WHERE id={5};", book.author, book.name, book.year, book.numberOfPages, book.price.ToString().Replace(',', '.'), book.id),
                String.Format("UPDATE \"Book\" SET genre='{1}' WHERE id={0};", book.id, book.genre)};
            foreach (var query in queries)
            {
                sqlCommand = new NpgsqlCommand(query, SQLCon.GetNpgsqlConnection());
                NpgsqlDataReader rr = sqlCommand.ExecuteReader();
                rr.Close();
            }

        }

        public void Update(Magazine magazine)
        {
            string[] queries = new string[] {
                String.Format("UPDATE \"Publication\" SET author='{0}', name='{1}', year={2}, pages={3}, price={4} WHERE id = {5};", magazine.author, magazine.name, magazine.year, magazine.numberOfPages, magazine.price.ToString().Replace(',', '.'), magazine.id),
                String.Format("UPDATE \"Magazine\" SET number={1}, frequency={2} WHERE id={0};", magazine.id, magazine.number, magazine.frequency)};
            foreach (var query in queries)
            {
                sqlCommand = new NpgsqlCommand(query, SQLCon.GetNpgsqlConnection());
                NpgsqlDataReader rr = sqlCommand.ExecuteReader();
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
        public void deleteBook(string id)
        {

            string[] queries = new string[] { string.Format("delete from \"Book\" where id = {0};", id),
                string.Format("delete from \"Publication\" where id = {0};", id) };

            foreach (var query in queries)
            {
                sqlCommand = new NpgsqlCommand(query, SQLCon.GetNpgsqlConnection());
                NpgsqlDataReader rr = sqlCommand.ExecuteReader();
                rr.Close();
            }
        }

        public void deleteMagazine(string id)
        {
            string[] queries = new string[] { string.Format("delete from \"Magazine\" where id = {0};", id),
                string.Format("delete from \"Publication\" where id = {0};", id) };

            foreach (var query in queries)
            {
                sqlCommand = new NpgsqlCommand(query, SQLCon.GetNpgsqlConnection());
                NpgsqlDataReader rr = sqlCommand.ExecuteReader();
                rr.Close();
            }
        }
    }
}
