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
    public partial class AdminAddAuthor : Form
    {
        public AdminAddAuthor()
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
                    var newAuthor = new Authors();

                    newAuthor.FirstName = textBox1.Text;
                    newAuthor.LastName = textBox2.Text;
                    newAuthor.Country = textBox3.Text;
                    newAuthor.BirthDate = DateTime.Parse(textBox4.Text);
                    newAuthor.City = textBox5.Text;
                    newAuthor.Sex = textBox6.Text;

                    db.Authors.Add(newAuthor);
                    db.SaveChanges();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Wystapil blad podczas zapisywania danych w bazie:\n\n" + exc);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Anuluj
            this.Hide();
        }
    }
}
