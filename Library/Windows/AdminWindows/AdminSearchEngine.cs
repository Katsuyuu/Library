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
    public partial class AdminSearchEngine : Form
    {
        public AdminSearchEngine()
        {
            InitializeComponent();

            // test

            using (var db = new LibraryEntities())
            {
                var users = (from u in db.Users
                             select new
                             {
                                 Index = u.Index,
                                 Imie = u.FirstName,
                                 Nazwisko = u.LastName,
                                 Admin = u.IsAdmin
                             }).ToList();

                dataGridView1.DataSource = users;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Edytuj
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Usun
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Wyszukaj
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Powrot

            this.Hide();
        }
    }
}
