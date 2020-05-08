using System;
using System.Drawing;
using System.Windows.Forms;
using BookShelf.db.DataBaseConnection;
using BookShelf.db.Entities;
using BookShelf.db.Query;

namespace BookShelf
{

    public partial class Insert : Form
    {
        private SQLCon cnn = new SQLCon();
        Book book = new Book();
        Magazine magazine = new Magazine();
        public Insert(Book book)
        {
            this.book = book;
            InitializeComponent();
            cnn.openConnection();
            fillBook();
            magazinePanel.Visible = true;
        }
        public Insert(Magazine magazine)
        {
            this.magazine = magazine;
            InitializeComponent();
            cnn.openConnection();
            fillMagazine();
            bookPanel.Visible = false;
        }

        public Insert(string flag)
        {

            InitializeComponent();
            cnn.openConnection();
            if (flag.Equals("book"))
            {
                magazinePanel.Visible = true;
            }
            else
            {
                bookPanel.Visible = false;
            }
        }

        private void BookAddButton_Click(object sender, System.EventArgs e)
        {
            if (BookAddButton.Text == "Update")
            {
                book = new Book(book.id, BookAuthor.Text, BookName.Text, int.Parse(BookPages.Text), int.Parse(BookYear.Text),
                    double.Parse(BookPrice.Text), BookGenre.Text);
                new QueryManager(cnn).Update(book);

            }
            else
            {
                book = new Book(BookAuthor.Text, BookName.Text, int.Parse(BookPages.Text), int.Parse(BookYear.Text),
                    double.Parse(BookPrice.Text), BookGenre.Text);
                new QueryManager(cnn).Insert(book);
                
            }
            Close();
        }

        private void MagazineAddButton_Click(object sender, EventArgs e)
        {
            if (MagazineAddButton.Text == "Update")
            {
                magazine = new Magazine(magazine.id, MagazineAuthor.Text, MagazineName.Text, int.Parse(MagazinePages.Text),
                    int.Parse(MagazineYear.Text), double.Parse(MagazinePrice.Text), int.Parse(MagazineFrequency.Text),
                    int.Parse(MagazineNumber.Text));
                new QueryManager(cnn).Update(magazine);
            }
            else
            {
                magazine = new Magazine(MagazineAuthor.Text, MagazineName.Text, int.Parse(MagazinePages.Text),
                    int.Parse(MagazineYear.Text), double.Parse(MagazinePrice.Text), int.Parse(MagazineFrequency.Text),
                    int.Parse(MagazineNumber.Text));
                new QueryManager(cnn).Insert(magazine);

            }
            Close();
        }

        private void BookCancel_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            Close();
        }

        private void MagazineCancel_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            Close();
        }
        private void fillMagazine()
        {
            MagazineAuthor.Text = magazine.author;
            MagazineName.Text = magazine.name;
            MagazinePrice.Text = magazine.price.ToString();
            MagazinePages.Text = magazine.numberOfPages.ToString();
            MagazineYear.Text = magazine.year.ToString();
            MagazineFrequency.Text = magazine.frequency.ToString();
            MagazineNumber.Text = magazine.number.ToString();
            MagazineAddButton.Text = "Update";
        }
        private void fillBook()
        {
            BookAuthor.Text = book.author;
            BookName.Text = book.name;
            BookPrice.Text = book.price.ToString();
            BookPages.Text = book.numberOfPages.ToString();
            BookYear.Text = book.year.ToString();
            BookGenre.Text = book.genre;
            BookAddButton.Text = "Update";

        }

        //
        // Book Insert Validation
        //
        // Book Author Validation
        //
        private void BookAuthor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (BookAuthor.Text.Length > 25 && BookAuthor.Text.Length < 1)
            {
                e.Cancel = true;
                BookAuthorValidation.Visible = true;
                BookAuthor.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                BookAuthorValidation.Visible = false;
                BookAuthor.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Book Name Validation
        //
        private void BookName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (BookName.Text.Length > 30 && BookName.Text.Length < 1)
            {
                e.Cancel = true;
                BookNameValidation.Visible = true;
                BookName.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                BookNameValidation.Visible = false;
                BookName.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Book Pages Validation
        //
        private void BookPages_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(int.TryParse(BookPages.Text, out _)))
            {
                e.Cancel = true;
                BookPagesValidation.Visible = true;
                BookPages.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                BookPagesValidation.Visible = false;
                BookPages.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Book Year Validation
        //
        private void BookYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(int.TryParse(BookYear.Text, out _)))
            {
                e.Cancel = true;
                BookYearValidation.Visible = true;
                BookYear.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                BookYearValidation.Visible = false;
                BookYear.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Book Price Validation
        //
        private void BookPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(double.TryParse(BookPrice.Text, out _)))
            {
                e.Cancel = true;
                BookPriceValidation.Visible = true;
                BookPrice.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                BookPriceValidation.Visible = false;
                BookPrice.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Book Genre Validation
        //
        private void BookGenre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (BookGenre.Text.Length > 15 && BookGenre.Text.Length < 1)
            {
                e.Cancel = true;
                BookGenreValidation.Visible = true;
                BookGenre.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                BookGenreValidation.Visible = false;
                BookGenre.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Magazine Insert Validation
        //
        // Magazine Author Validation
        //
        private void MagazineAuthor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MagazineAuthor.Text.Length > 25 && MagazineAuthor.Text.Length < 1)
            {
                e.Cancel = true;
                MagazineAuthorValidation.Visible = true;
                MagazineAuthor.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                MagazineAuthorValidation.Visible = false;
                MagazineAuthor.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Magazine Name Validation
        //
        private void MagazineName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MagazineName.Text.Length > 30 && MagazineName.Text.Length < 1)
            {
                e.Cancel = true;
                MagazineNameValidation.Visible = true;
                MagazineName.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                MagazineNameValidation.Visible = false;
                MagazineName.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Magazine Pages Validation
        //
        private void MagazinePages_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(int.TryParse(MagazinePages.Text, out _)))
            {
                e.Cancel = true;
                MagazinePagesValidation.Visible = true;
                MagazinePages.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                MagazinePagesValidation.Visible = false;
                MagazinePages.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Magazine Year Validation
        //
        private void MagazineYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(int.TryParse(MagazineYear.Text, out _)))
            {
                e.Cancel = true;
                MagazineYearValidation.Visible = true;
                MagazineYear.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                MagazineYearValidation.Visible = false;
                MagazineYear.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Magazine Price Validation
        //
        private void MagazinePrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(double.TryParse(MagazinePrice.Text, out _)))
            {
                e.Cancel = true;
                MagazinePriceValidation.Visible = true;
                MagazinePrice.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                MagazinePriceValidation.Visible = false;
                MagazinePrice.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Magazine Frequency Validation
        //
        private void MagazineFrequency_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(double.TryParse(MagazineFrequency.Text, out _)))
            {
                e.Cancel = true;
                MagazineFrequencyValidation.Visible = true;
                MagazineFrequency.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                MagazineFrequencyValidation.Visible = false;
                MagazineFrequency.BackColor = Color.LightSteelBlue;
            }
        }
        //
        // Magazine Number Validation
        //
        private void MagazineNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(double.TryParse(MagazineNumber.Text, out _)))
            {
                e.Cancel = true;
                MagazineNumberValidation.Visible = true;
                MagazineNumber.BackColor = Color.DarkSalmon;
            }
            else
            {
                e.Cancel = false;
                MagazineNumberValidation.Visible = false;
                MagazineNumber.BackColor = Color.LightSteelBlue;
            }
        }
    }
}
