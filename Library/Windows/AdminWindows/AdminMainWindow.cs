using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Windows.AdminWindows.Adders;

namespace Library.Windows.AdminWindows
{
    public partial class AdminMainWindow : Form
    {
        public AdminMainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dodaj ksiazke

            AdminAddBook x = new AdminAddBook();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Dodaj Autora

            AdminAddAuthor x = new AdminAddAuthor();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Dodaj Wydawnictwo

            AdminAddPublisher x = new AdminAddPublisher();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Dodaj Uzytkownika

            AdminAddUser x = new AdminAddUser();
            x.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Kontrola Wypozyczen

            AdminBorrowControl x = new AdminBorrowControl();
            x.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Wyloguj

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Edytuj Profil

            AdminEditProfile x = new AdminEditProfile();
            x.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Wyszukaj

            AdminSearchEngine x = new AdminSearchEngine();
            x.Show();
        }
    }
}
