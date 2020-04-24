using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShelf.db.DataBaseConnection;
using BookShelf.db.Entities;
using Npgsql;
using BookShelf.db.Query;
using BookShelf.Files;

namespace BookShelf
{
    public partial class BookShelf : Form
    {
        public SQLCon cnn = new SQLCon();

        public BookShelf()
        {
            InitializeComponent();
            cnn.openConnection();
        }


        private void ExitTItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookShelf_Load(object sender, EventArgs e)
        {
            //TODO: ADD LOADER (PROGRESS BAR)
            Button helloButton = new Button();
            helloButton.BackColor = Color.LightGray;
            helloButton.ForeColor = Color.DarkGray;
            helloButton.Location = new Point(10, 10);
            helloButton.Text = "Привет";
            this.Controls.Add(helloButton);
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Database1DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PreInsert preinsertform = new PreInsert();
            preinsertform.Show();
        }

        private void ShowPublications()
        {
            dataGridView1.Columns["Number"].Visible = true;
            dataGridView1.Columns["Frequency"].Visible = true;
            dataGridView1.Columns["Genre"].Visible = true;

            dataGridView1.Rows.Clear();
            LinkedList<Book> books = new QueryManager(cnn).SelectAllBooks();
            LinkedList<Magazine> magazines = new QueryManager(cnn).SelectAllMagazines();
            foreach (var book in books)
            {
                string[] rowStrings = new string[8];
                rowStrings[0] = book.author.ToString();
                rowStrings[1] = book.name.ToString();
                rowStrings[2] = book.numberOfPages.ToString();
                rowStrings[3] = book.year.ToString();
                rowStrings[4] = book.price.ToString();
                rowStrings[5] = " ";
                rowStrings[6] = " ";
                rowStrings[7] = book.genre.ToString();
                dataGridView1.Rows.Add(rowStrings);
            }
            foreach (var magazine in magazines)
            {
                dataGridView1.Rows.Add(magazine.ToString().Split(';'));
            }
        }
        private void ShowAll_Click(object sender, EventArgs e)
        {
            ShowPublications();
        }

        private void ShowBooks_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Number"].Visible = false;
            dataGridView1.Columns["Frequency"].Visible = false;
            dataGridView1.Columns["Genre"].Visible = true;

            dataGridView1.Rows.Clear();
            LinkedList<Book> books = new QueryManager(cnn).SelectAllBooks();
            foreach (var book in books)
            {
                string[] rowStrings = new string[8];
                rowStrings[0] = book.author.ToString();
                rowStrings[1] = book.name.ToString();
                rowStrings[2] = book.numberOfPages.ToString();
                rowStrings[3] = book.year.ToString();
                rowStrings[4] = book.price.ToString();
                rowStrings[5] = " ";
                rowStrings[6] = " ";
                rowStrings[7] = book.genre.ToString();
                dataGridView1.Rows.Add(rowStrings);
                //dataGridView1.Rows.Add(book.ToString().Split('\t'));

            }
        }

        private void ShowMagazines_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Number"].Visible = true;
            dataGridView1.Columns["Frequency"].Visible = true;
            dataGridView1.Columns["Genre"].Visible = false;
            dataGridView1.Rows.Clear();
            LinkedList<Magazine> magazines = new QueryManager(cnn).SelectAllMagazines();
            foreach (var magazine in magazines)
            {
                dataGridView1.Rows.Add(magazine.ToString().Split(';'));



            }
        }

        private void MagazineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Insert insertForm = new Insert("magazine");
            insertForm.Show();
        }

        private void BookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Insert insertForm = new Insert("book");
            insertForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void ViewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help helpForm = new Help();
            helpForm.Show();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkedList<Book> books = new QueryManager(cnn).SelectAllBooks();
            LinkedList<Magazine> magazines = new QueryManager(cnn).SelectAllMagazines();

            new FileManager().SaveToFile(books, magazines);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinkedList<Book> books = new QueryManager(cnn).SelectAllBooks();
            LinkedList<Magazine> magazines = new QueryManager(cnn).SelectAllMagazines();

            new FileManager().saveAsToFile(books, magazines);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QueryManager(cnn).clearTables();
            QueryManager queryManager = new QueryManager(cnn);
            (LinkedList<Book> books, LinkedList<Magazine> magazines) = new FileManager().OpenFile();
            foreach (var book in books)
            {
                queryManager.Insert(book);
            }

            foreach (var magazine in magazines)
            {
                queryManager.Insert(magazine);
            }

            ShowPublications();
        }


        private void CreateNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
