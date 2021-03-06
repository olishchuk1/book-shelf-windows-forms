﻿using System;
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
        List<Book> books;
        List<Magazine> magazines;

        public SQLCon cnn = new SQLCon();

        public BookShelf()
        {
            InitializeComponent();
            cnn.openConnection();
        }


        private void ExitTItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookShelf_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PreInsert preinsertform = new PreInsert();
            preinsertform.Show();
        }

        public void ShowPublications()
        {
            dataGridView1.Columns["Author"].Visible = true;
            dataGridView1.Columns["Naming"].Visible = true;
            dataGridView1.Columns["Pages"].Visible = true;
            dataGridView1.Columns["Year"].Visible = true;
            dataGridView1.Columns["Price"].Visible = true;
            dataGridView1.Columns["Number"].Visible = true;
            dataGridView1.Columns["Frequency"].Visible = true;
            dataGridView1.Columns["Genre"].Visible = true;

            dataGridView1.Rows.Clear();
            books = new QueryManager(cnn).SelectAllBooks();
            magazines = new QueryManager(cnn).SelectAllMagazines();
            foreach (var book in books)
            {
                string[] rowStrings = new string[9];
                rowStrings[0] = book.id.ToString();
                rowStrings[1] = book.author;
                rowStrings[2] = book.name;
                rowStrings[3] = book.numberOfPages.ToString();
                rowStrings[4] = book.year.ToString();
                rowStrings[5] = book.price.ToString();
                rowStrings[6] = " ";
                rowStrings[7] = " ";
                rowStrings[8] = book.genre;
                dataGridView1.Rows.Add(rowStrings);
            }

            foreach (var magazine in magazines)
            {
                dataGridView1.Rows.Add((magazine.id.ToString() + ";" + magazine.ToString()).Split(';'));
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            ShowPublications();
        }

        private void ShowBooks_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Author"].Visible = true;
            dataGridView1.Columns["Naming"].Visible = true;
            dataGridView1.Columns["Pages"].Visible = true;
            dataGridView1.Columns["Year"].Visible = true;
            dataGridView1.Columns["Price"].Visible = true;
            dataGridView1.Columns["Number"].Visible = false;
            dataGridView1.Columns["Frequency"].Visible = false;
            dataGridView1.Columns["Genre"].Visible = true;

            dataGridView1.Rows.Clear();
            books = new QueryManager(cnn).SelectAllBooks();
            foreach (var book in books)
            {
                string[] rowStrings = new string[9];
                rowStrings[0] = book.id.ToString();
                rowStrings[1] = book.author.ToString();
                rowStrings[2] = book.name.ToString();
                rowStrings[3] = book.numberOfPages.ToString();
                rowStrings[4] = book.year.ToString();
                rowStrings[5] = book.price.ToString();
                rowStrings[6] = " ";
                rowStrings[7] = " ";
                rowStrings[8] = book.genre.ToString();
                dataGridView1.Rows.Add(rowStrings);
                //dataGridView1.Rows.Add(book.ToString().Split('\t'));

            }
        }

        private void ShowMagazines_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Author"].Visible = true;
            dataGridView1.Columns["Naming"].Visible = true;
            dataGridView1.Columns["Pages"].Visible = true;
            dataGridView1.Columns["Year"].Visible = true;
            dataGridView1.Columns["Price"].Visible = true;
            dataGridView1.Columns["Number"].Visible = true;
            dataGridView1.Columns["Frequency"].Visible = true;
            dataGridView1.Columns["Genre"].Visible = false;
            dataGridView1.Rows.Clear();
            magazines = new QueryManager(cnn).SelectAllMagazines();
            foreach (var magazine in magazines)
            {
                dataGridView1.Rows.Add((magazine.id.ToString() + ";" + magazine.ToString()).Split(';'));
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
            Close();
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
            books = new QueryManager(cnn).SelectAllBooks();
            magazines = new QueryManager(cnn).SelectAllMagazines();

            new FileManager().SaveToFile(books, magazines);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            books = new QueryManager(cnn).SelectAllBooks();
            magazines = new QueryManager(cnn).SelectAllMagazines();

            new FileManager().saveAsToFile(books, magazines);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QueryManager(cnn).clearTables();
            QueryManager queryManager = new QueryManager(cnn);
            (books, magazines) = new FileManager().OpenFile();
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
            new QueryManager(cnn).clearTables();
            ShowPublications();
        }

        private void CloseFilterLabel_Click(object sender, EventArgs e)
        {
            FilterPanel.Visible = false;
        }

        private void OpenFilterLabel_Click(object sender, EventArgs e)
        {
            FilterPanel.Visible = true;
        }

        private void CloseFilterLabel_MouseHover(object sender, EventArgs e)
        {
            CloseFilterLabel.ForeColor = Color.DimGray;
        }

        private void OpenFilterLabel_MouseHover(object sender, EventArgs e)
        {
            OpenFilterLabel.ForeColor = Color.DimGray;
        }

        private void OpenFilterLabel_MouseLeave(object sender, EventArgs e)
        {
            OpenFilterLabel.ForeColor = Color.WhiteSmoke;
        }

        private void CloseFilterLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseFilterLabel.ForeColor = Color.WhiteSmoke;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string id = row.Cells["ID"].Value.ToString();
            QueryManager queryManager = new QueryManager(cnn);

            if (isBook(id))
            {
                queryManager.deleteBook(id);
            }
            else
            {
                queryManager.deleteMagazine(id);
            }

            ShowPublications();
        }

        private bool isBook(string id)
        {
            return books.Exists(x => x.id.ToString().Equals(id));
        }

        private bool isOffice(string id)
        {
            return magazines.Exists(x => x.id.ToString().Equals(id));
        }

        private Book GetBook(string id)
        {
            return books.Where(x => x.id == int.Parse(id)).First();
        }

        private Magazine GetMagazine(string id)
        {
            return magazines.Where(x => x.id == int.Parse(id)).First();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string id = row.Cells["ID"].Value.ToString();
            QueryManager queryManager = new QueryManager(cnn);

            if (isBook(id))
            {
                Book book = GetBook(id);
                Insert insertForm = new Insert(book);
                insertForm.Show();
            }
            else
            {
                Magazine magazine = GetMagazine(id);
                Insert insertForm = new Insert(magazine);
                insertForm.Show();
            }

            ShowPublications();
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["Author"].Visible = AuthorCheckBox.Checked;
            dataGridView1.Columns["Naming"].Visible = NameCheckBox.Checked;
            dataGridView1.Columns["Pages"].Visible = PagesCheckBox.Checked;
            dataGridView1.Columns["Year"].Visible = YearCheckBox.Checked;
            dataGridView1.Columns["Price"].Visible = PriceCheckBox.Checked;
            dataGridView1.Columns["Frequency"].Visible = FrequencyCheckBox.Checked;
            dataGridView1.Columns["Number"].Visible = NumberCheckBox.Checked;
            dataGridView1.Columns["Genre"].Visible = GenreCheckBox.Checked;
        }

        private void DataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            try
            {
                if (int.TryParse(e.CellValue1.ToString(), out _))
                {
                    try
                    {
                        int a = int.Parse(e.CellValue1.ToString()), b = int.Parse(e.CellValue2.ToString());
                        e.SortResult = a.CompareTo(b);
                        e.Handled = true;
                    }
                    catch (Exception exception)
                    {
                        e.SortResult = 1;
                    }

                }
                else if (double.TryParse(e.CellValue1.ToString(), out _))
                {
                    double a = double.Parse(e.CellValue1.ToString()), b = double.Parse(e.CellValue2.ToString());
                    e.SortResult = a.CompareTo(b);
                    e.Handled = true;
                }

            }
            catch (Exception exception)
            {
                e.SortResult = 1;
            }
        }
    }
}
