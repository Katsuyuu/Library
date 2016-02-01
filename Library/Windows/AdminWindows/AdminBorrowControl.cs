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
    public partial class AdminBorrowControl : Form
    {
        public AdminBorrowControl()
        {
            InitializeComponent();

            try
            {
                using (var db = new LibraryEntities())
                {
                    var borrowController = (from bc in db.BorrowController
                                            join b in db.Books on bc.BookID equals b.BookID
                                            select new
                                            {
                                                Indeks = bc.Index,
                                                Tytul = bc.Books.Title,
                                                Autor = b.Authors.FirstName + b.Authors.LastName,
                                                Od = bc.From,
                                                Do = bc.To
                                            });

                    dataGridView1.DataSource = borrowController.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystapil blad podczas laczenia z baza danych:\n\n" + ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Powrot

            this.Hide();
        }
    }
}
