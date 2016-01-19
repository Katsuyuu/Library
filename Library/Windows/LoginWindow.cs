using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using System.Data.SqlClient;
using Library.Windows.AdminWindows;
using Library.Windows.UserWindows;

namespace Library.Windows
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DO TESTOW, COBY NIE MUSIEC CO CHWILE SIE LOGOWAC NA ADMINA
            AdminMainWindow adminMainWindow = new AdminMainWindow();
            adminMainWindow.Show();

        }
    }
}
