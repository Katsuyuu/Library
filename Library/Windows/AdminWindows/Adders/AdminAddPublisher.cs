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
    public partial class AdminAddPublisher : Form
    {
        public AdminAddPublisher()
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
                    var newPublisher = new Publishers();

                    newPublisher.Name = textBox1.Text;
                    newPublisher.City = textBox2.Text;
                    newPublisher.Street = textBox3.Text;
                    newPublisher.HouseNumber = textBox4.Text;
                    newPublisher.ApartmentNumber = Convert.ToInt32(textBox5.Text);

                    db.Publishers.Add(newPublisher);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Anuluj

            this.Hide();
        }
    }
}
