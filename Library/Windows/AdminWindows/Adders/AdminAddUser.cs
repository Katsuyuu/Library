﻿using System;
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
    public partial class AdminAddUser : Form
    {
        public AdminAddUser()
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
                    
                    var newUser = new Users();

                    newUser.Index = Convert.ToInt32(textBox11.Text);
                    newUser.Password = textBox1.Text;
                    newUser.FirstName = textBox2.Text;
                    newUser.LastName = textBox3.Text;
                    newUser.BirthDate = DateTime.Parse(textBox4.Text);
                    newUser.Sex = textBox5.Text;
                    newUser.Email = textBox6.Text;
                    newUser.City = textBox7.Text;
                    newUser.Street = textBox8.Text;
                    newUser.HouseNumber = textBox9.Text; //Convert.ToInt32(textBox9.Text);
                    newUser.ApartmentNumber = Convert.ToInt32(textBox10.Text);

                    db.Users.Add(newUser);
                    db.SaveChanges();
                    
                    db.Users.Add(newUser);
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
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Anuluj

            this.Hide();
        }
    }
}
