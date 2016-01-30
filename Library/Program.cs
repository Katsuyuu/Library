using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Windows;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        

        // komentarz
        static DatabaseConnection DBConnection;

        [STAThread]
        static void Main()
        {
            DBConnection = new DatabaseConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());          
        }
    }
}
