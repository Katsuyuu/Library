using Library;
using Library.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            DatabaseConnection newConnection = new DatabaseConnection();
            
            // dla testow

            string napis = newConnection.Test();
            textBox1.Text = napis;

            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }
    }
}
