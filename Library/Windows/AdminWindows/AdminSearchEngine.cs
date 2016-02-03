using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Windows.AdminWindows
{
    public partial class AdminSearchEngine : Form
    {
        public int flaga = 0;

        public AdminSearchEngine()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Wyszukaj

            flaga = 0;

            using (var db = new LibraryEntities())
            {
                try
                {
                    #region WYSZUKIWANIE KSIAZKI FLAGA=1
                    
                    var books = (from b in db.Books 
                                 join a in db.Authors on b.AuthorID equals a.AuthorID
                                 join p in db.Publishers on b.PublisherID equals p.PublisherID
                                 select new
                                 {
                                     ID = b.BookID,
                                     Tytul = b.Title,
                                     Autor = b.Authors.FirstName + " " + b.Authors.LastName,
                                     Wydawnictwo = b.Publishers.Name,
                                     Rok_Wydania = b.PublishYear,
                                     Ilosc = b.Quantity,
                                     Dni_wypozyczenia = b.BorrowLimit
                                 });

                    if (!string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        books = books.Where(x => x.Tytul.Contains(textBox1.Text));
                        flaga = 1;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    {
                        books = books.Where(x => x.Rok_Wydania.ToString().Contains(textBox2.Text));
                        flaga = 1;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        books = books.Where(x => x.Wydawnictwo.Contains(textBox3.Text));
                        flaga = 1;
                    }

                    books.ToList();

                    if (flaga == 1)
                    {
                        dataGridView1.DataSource = books.ToList();                        
                    }
                    
                    #endregion

                    #region WYSZUKIWANIE AUTOROW FLAGA=2

                    var authors = (from a in db.Authors
                                   select new
                                   {
                                       ID = a.AuthorID,
                                       Imie = a.FirstName,
                                       Nazwisko = a.LastName,
                                       Data_urodzenia = a.BirthDate,
                                       Plec = a.Sex,
                                       Kraj = a.Country,
                                       Miasto = a.City
                                   });

                    if (!string.IsNullOrWhiteSpace(textBox4.Text))
                    {
                        authors = authors.Where(x => x.Imie.Contains(textBox4.Text));
                        flaga = 2;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox5.Text))
                    {
                        authors = authors.Where(x => x.Nazwisko.Contains(textBox5.Text));
                        flaga = 2;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox6.Text))
                    {
                        authors = authors.Where(x => x.Kraj.Contains(textBox6.Text));
                        flaga = 2;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox7.Text))
                    {
                        authors = authors.Where(x => x.Data_urodzenia.ToString().Contains(textBox7.Text));
                        flaga = 2;
                    }

                    if (flaga == 2)
                    {
                        dataGridView1.DataSource = authors.ToList();
                    }

                    #endregion

                    #region WYSZUKIWANIE UZYTKONWIKOW FLAGA=3

                    var users = from u in db.Users
                                select new
                                {
                                    Indeks = u.Index,
                                    Haslo = u.Password,
                                    Imie = u.FirstName,
                                    Nazwisko = u.LastName,
                                    Data_urodzenia = u.BirthDate,
                                    Plec = u.Sex,
                                    Email = u.Email,
                                    Miasto = u.City,
                                    Ulica = u.Street,
                                    Numer_domu = u.HouseNumber,
                                    Numer_mieszkania = u.ApartmentNumber,
                                    Admin = u.IsAdmin
                                };

                    if(!string.IsNullOrWhiteSpace(textBox8.Text))
                    {
                        users = users.Where(x => x.Imie.Contains(textBox8.Text));
                        flaga = 3;
                    }

                    if(!string.IsNullOrWhiteSpace(textBox9.Text))
                    {
                        users = users.Where(x => x.Nazwisko.Contains(textBox9.Text));
                        flaga = 3;
                    }

                    if(!string.IsNullOrWhiteSpace(textBox10.Text))
                    {
                        users = users.Where(x => x.Indeks.ToString().Contains(textBox10.Text));
                        flaga = 3;
                    }

                    if (!string.IsNullOrWhiteSpace(textBox11.Text))
                    {
                        users = users.Where(x => x.Data_urodzenia.ToString().Contains(textBox11.Text));
                        flaga = 3;
                    }

                    if (flaga == 3)
                    {
                        dataGridView1.DataSource = users.ToList();
                    }

                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystapil blad podczas laczenia z baza danych:\n\n" + ex);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Powrot

            this.Hide();
        }

        private void usuńWierszToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
