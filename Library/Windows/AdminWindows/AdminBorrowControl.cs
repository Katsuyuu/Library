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

            using (var db = new LibraryEntities())
            {
                var borrowController = (from bc in db.BorrowController
                             select new
                             {
                                 Indeks = bc.Index,
                                 Ksiazka = bc.Index,    // ogarnac ladne wyswietlanie ksiazki
                                 Od = bc.From,
                                 Do = bc.To
                             }).ToList();

                dataGridView1.DataSource = borrowController;
            }

        }
    }
}
