using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Windows.UserWindows
{
    public partial class UsersSearchPublishers : Form
    {
        UserMainWindow mainWindow;
        public UsersSearchPublishers(UserMainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        public void wyswietl_wydawnictwa()
        {
            using (var db = new LibraryEntities())
            {

                var publishers = from p in db.Publishers
                            
                             select new
                             {
                                 Name = p.Name,
                                 City = p.City

                             };

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    publishers = publishers.Where(x => x.Name.Contains(textBox1.Text));
                }

                dataGridView1.DataSource = publishers.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wyswietl_wydawnictwa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //powrót
            mainWindow.Show();
            this.Hide();
        }
    }
}
