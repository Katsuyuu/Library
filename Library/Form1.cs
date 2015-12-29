using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DatabaseConnection NewConnection = new DatabaseConnection();

            NewConnection.Connect();
            /*
            string napis = "";
            napis = NewConnection.Test();

            textBox1.AppendText(napis);
            */
        }
    }
}
