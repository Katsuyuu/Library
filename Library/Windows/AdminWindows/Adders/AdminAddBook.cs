using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Windows.AdminWindows.Adders
{
    public partial class AdminAddBook : Form
    {
        public AdminAddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dodaj

            using (var db = new LibraryEntities())
            {
                try
                {
                    var newBook = new Books();

                    newBook.AuthorID = (from a in db.Authors
                                       where a.FirstName == textBox1.Text
                                       where a.LastName == textBox2.Text
                                       select a.AuthorID).FirstOrDefault();
                    newBook.Title = textBox3.Text;
                    newBook.PublisherID = (from p in db.Publishers
                                           where p.Name == textBox4.Text
                                           select p.PublisherID).FirstOrDefault();
                    newBook.PublishYear = Convert.ToInt32(textBox5.Text);
                    newBook.Quantity = Convert.ToInt32(textBox6.Text);
                    newBook.BorrowLimit = Convert.ToInt32(textBox7.Text);

                    if (newBook.BorrowLimit == 0)
                    {
                        MessageBox.Show("Maksymalna ilosc dni wypozyczenia nie moze byc = 0!");
                        return;
                    }

                    db.Books.Add(newBook);
                    db.SaveChanges();
                }

                catch (FormatException)
                {
                    MessageBox.Show("Nie wszystkie wymagane pola zostaly wypelnione!");
                    return;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Wystapil blad podczas zapisywania danych w bazie:\n\n" + ex);
                    return;
                }

                MessageBox.Show("Rekord pomyslnie zapisano!");
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Resetuj
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Anuluj
            this.Hide();
        }
    }
}
