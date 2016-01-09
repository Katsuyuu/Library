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
    public partial class SelectBookTitle : Form
    {
        public SelectBookTitle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tytul = textBox1.ToString();
            using (var dc = new LibraryEntities())
            {

                var book = from b in dc.Books
                           where b.Title == @tytul  // nie dziala :( 
                           select new
                           {
                               Title = b.Title,
                               Author = b.Author,
                               PublisYear = b.PublishYear,
                               Quantity = b.Quantity

                           }; 

                /* var book = from b in dc.Books
                            where b.Title == textBox1.ToString()
                            select b;*/

                dataGridView1.DataSource = book.ToList();
            }
        }
    }
}
