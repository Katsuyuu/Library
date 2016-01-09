using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;
using System.Data.SqlClient;
using Library.Windows.AdminWindows;
using Library.Windows.UserWindows;

namespace Library.Windows
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand checkAdmin = new SqlCommand("select * from Users" +
                                                    " where \"Index\" = " + textBox1.Text +
                                                    " and \"Password\" = '" + textBox2.Text + "'", DatabaseConnection.conn);
            
            SqlDataReader rdr = checkAdmin.ExecuteReader();

            try
            {
                while (rdr.Read())
                {
                    if (textBox1.Text == "" || textBox2.Text == "")
                    {
                        MessageBox.Show("Nie podales danych! Sprobuj ponownie");
                    }
                    else
                    {
                        //if (rdr[11].Equals(true))             // to dziala, ale rozwiazanie dosc slabe
                        if (rdr.GetSqlBoolean(11) == true)      // w sumie podobne :D
                        {
                            AdminMainWindow adminMainWindow = new AdminMainWindow();
                            adminMainWindow.Show();
                            adminMainWindow.Activate();
                            this.Hide();
                        }
                        else
                        {
                            UserMainWindow userMainWindow = new UserMainWindow();
                            userMainWindow.Show();
                            userMainWindow.Activate();
                            this.Hide();
                        }
                    }
                }
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
            }
        }
    }
}
