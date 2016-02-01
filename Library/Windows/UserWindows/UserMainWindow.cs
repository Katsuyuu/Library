using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Windows.UserWindows
{
    public partial class UserMainWindow : Form
    {
       public UserSearchAuthors userSearchAuthor;
       public UserSearchBooks userSearchBook;
       public UserBorrowHistory userBorrowHistory;
        public UsersSearchPublishers userSearchPublishers;
        
        public UserMainWindow()
        {
            InitializeComponent();
            userSearchAuthor = new UserSearchAuthors(this);
            userSearchBook = new UserSearchBooks(this);
            userBorrowHistory = new UserBorrowHistory(this);
            userSearchPublishers = new UsersSearchPublishers(this);
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //wyszukaj autorow
          
            userSearchAuthor.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wyszukaj ksiazki
          
            userSearchBook.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //wyloguj
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            userBorrowHistory.Show();
            userBorrowHistory.wyswietl();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //wydawnictwa
            userSearchPublishers.Show();
            this.Hide();
        }
    }
}
