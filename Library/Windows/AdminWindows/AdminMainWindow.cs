using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Windows.AdminWindows
{
    public partial class AdminMainWindow : Form
    {
        public AdminMainWindow()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminSearchEngine x = new AdminSearchEngine();
            x.Show();
        }
    }
}
