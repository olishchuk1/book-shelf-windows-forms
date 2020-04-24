using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShelf
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadingForm loadForm = new LoadingForm();
            DateTime timeLoad = DateTime.Now + TimeSpan.FromSeconds(4);
            loadForm.Show();
            //loadForm.Loading(40);
            // System.Threading.Thread.Sleep(5000);
            while (timeLoad > DateTime.Now)
            {
                Application.DoEvents();
            }
            loadForm.Close();
            loadForm.Dispose();
            Application.Run(new BookShelf());
        }
    }
}
