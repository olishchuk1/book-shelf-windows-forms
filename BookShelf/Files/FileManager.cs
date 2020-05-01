using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShelf.db.Entities;

namespace BookShelf.Files
{
    class FileManager
    {
        public void SaveToFile(List<Book> bookList, List<Magazine> magazineList, String filename= ".\\default.txt")
        {
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (var book in bookList)
                {
                    sw.WriteLine(book);
                }
                foreach (var magazine in magazineList)
                {
                    sw.WriteLine(magazine);
                }
            }
            MessageBox.Show("Saved");
        }

        public void saveAsToFile(List<Book> bookList, List<Magazine> magazineList)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "System File (*.txt) | *.txt";
            saveFileDialog1.Title = "Save File As";
            saveFileDialog1.ShowDialog();

            using (var fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (var book in bookList)
                    {
                        sw.WriteLine(book);
                        sw.Flush();
                    }
                    foreach (var magazine in magazineList)
                    {
                        sw.WriteLine(magazine);
                        sw.Flush();
                    }
                }
                MessageBox.Show("Saved");
            }
        }

        public (List<Book>, List<Magazine>) OpenFile()
        {
            List<Book> books = new List<Book>();
            List<Magazine> magazines = new List<Magazine>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "System File (*.txt) | *.txt";
            openFileDialog.Title = "Open File As";
            openFileDialog.ShowDialog();

            using (var fs = new FileStream(openFileDialog.FileName, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (sr.Peek() > 0)
                    {
                        string[] line = sr.ReadLine().Split(';');
                        if (line.Length == 7)
                        {
                            magazines.Add(ConvertToMagazine(line));
                        }
                        else
                        {
                            books.Add(ConvertToBook(line));
                        }
                    }
                    
                }
                //MessageBox.Show("Done");
            }

            return (books, magazines);
        }

        private Book ConvertToBook(string[] line)
        {
            return new Book(line[0], line[1], Int32.Parse(line[2]), Int32.Parse(line[3]), double.Parse(line[4]), line[5]);
        }

        private Magazine ConvertToMagazine(string[] line)
        {
            return new Magazine(line[0], line[1], Int32.Parse(line[2]), Int32.Parse(line[3]), double.Parse(line[4]), Int32.Parse(line[5]), Int32.Parse(line[6]));
        }
    }
}
