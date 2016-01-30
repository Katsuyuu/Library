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
