﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using Library.Windows;
using System.Collections;
using System.Linq.Expressions;

namespace Library.Windows.UserWindows
{
       
    public partial class UserBorrowHistory : Form
    {
        public UserMainWindow mainWindow;

        public UserBorrowHistory(UserMainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
           
        }

        public void wyswietl()
        {
            //MessageBox.Show(""+mainWindow.userSearchAuthor.lista.Count());
            foreach (string nazwa in mainWindow.userSearchAuthor.lista)
            {
                richTextBox1.Text = nazwa;
               
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            mainWindow.Show();
            this.Hide();
        }
    }
}
