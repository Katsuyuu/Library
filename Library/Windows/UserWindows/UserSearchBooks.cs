using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Library;

namespace Library.Windows.UserWindows
{
    public partial class UserSearchBooks : Form
    {
        UserMainWindow mainWindow;
        public int czas_do;
        public UserSearchBooks(UserMainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        public void wyswietl_ksiazki()
        {

            //IEnumerable<dynamic> book;
            //List<IEnumerable> lista = new List<IEnumerable>();

            using (var db = new LibraryEntities())
            {

                var book = from b in db.Books join a in db.Authors on b.AuthorID equals a.AuthorID
                           join p in db.Publishers on b.PublisherID equals p.PublisherID
                           select new
                           {
                               Title = b.Title,
                               AuthorFirstName = a.FirstName,
                               AuthorLastName = a.LastName,
                               Publishers = p.Name,
                               PublishYear = b.PublishYear,
                               BorrowLimit = b.BorrowLimit,
                               Quantity = b.Quantity

                         };

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    book = book.Where(x => x.Title.Contains(textBox1.Text));
                    
                }

                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    book = book.Where(x => x.AuthorFirstName.Contains(textBox2.Text));
                    
                }

                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    book = book.Where(x => x.PublishYear  == Int32.Parse(textBox3.Text));
                }

                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                {
                   book = book.Where(x => x.Publishers.Contains(textBox4.Text));
                }


                dataGridView1.DataSource = book.ToList();
                
            }

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wyswietl
            wyswietl_ksiazki();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dataGridView1.DataSource = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //powrót
            mainWindow.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //wybranie konkretnego wiersza
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            DataGridViewCellCollection cell = row.Cells;

            // zmniejszenie ilosci wypozyczenia
            int quantity = Int32.Parse(cell[6].Value.ToString());
            quantity--;

            czas_do = Int32.Parse(cell[5].Value.ToString());

            //konwert do stringa pierwszych trzech pol, czyli imie, nazwisko i tytuł ksiazki
            string nazwaa = cell[1].Value.ToString() + " " + cell[2].Value.ToString() + " " + cell[0].Value.ToString();

            mainWindow.userSearchAuthor.lista.Add(nazwaa);

            MessageBox.Show("Wypożyczono!");
        }
    }
}
