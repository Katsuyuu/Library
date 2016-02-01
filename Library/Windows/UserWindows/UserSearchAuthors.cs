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
using System.Linq.Expressions;



namespace Library.Windows.UserWindows
{
    public partial class UserSearchAuthors : Form
    {
        public List<string> lista; // = new List<string>();
        

        public UserMainWindow mainWindow;
        public UserSearchAuthors(UserMainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            lista = new List<string>();
        }

        public void wyswietl_autora()
        {

            using (var db = new LibraryEntities())
            {

                var author = from a in db.Authors join b in db.Books on a.AuthorID equals b.AuthorID 
                             select new
                             {
                                 FirstName = a.FirstName, 
                                 LastName = a.LastName,
                                 BookTitle = b.Title,
                                 BirthDate = a.BirthDate,
                                 Country = a.Country,
                                 City = a.City,
                                 Quantity = b.Quantity,
                                 BorrowLimit = b.BorrowLimit

                             };

                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    author = author.Where(x => x.FirstName.Contains(textBox1.Text));
                }

                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    author = author.Where(x => x.LastName.Contains(textBox2.Text));
                }

                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    author = author.Where(x => x.Country.Contains(textBox3.Text));
                }

                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    author = author.Where(x => x.BirthDate.ToString().Contains(textBox4.Text));
                }

                dataGridView1.DataSource = author.ToList();
                
            }

           
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            //wyswietl autora wedlug kryteriow
            wyswietl_autora();
            
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //wyczysc
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dataGridView1.DataSource = null;
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        public void button3_Click(object sender, EventArgs e)
        {
            //wypozycz
            //wybranie konkretnego wiersza
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            DataGridViewCellCollection cell = row.Cells;

            // zmniejszenie ilosci wypozyczenia
            int quantity = Int32.Parse(cell[6].Value.ToString());
            quantity--;
            
            mainWindow.userSearchBook.czas_do = Int32.Parse(cell[7].Value.ToString());

            //konwert do stringa pierwszych trzech pol, czyli imie, nazwisko i tytuł ksiazki
            string nazwaa = cell[0].Value.ToString() + " " + cell[1].Value.ToString() + " " + cell[2].Value.ToString();
            lista.Add(nazwaa);
            
            MessageBox.Show("Wypożyczono!");

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Hide();
        }
    }
}
