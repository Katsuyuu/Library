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

            DatabaseConnection db = new DatabaseConnection();
        }

        private void ButtonLogowanie_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }
    }
}
