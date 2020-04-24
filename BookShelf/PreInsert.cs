using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShelf
{
    public partial class PreInsert : Form
    {
        public PreInsert()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewMagazine_Click(object sender, EventArgs e)
        {
            Insert insertForm = new Insert("magazine");
            insertForm.Show();
            Close();
        }

        private void AddNewBook_Click(object sender, EventArgs e)
        {
            Insert insertForm = new Insert("book");
            insertForm.Show();
            Close();
        }
    }
}
