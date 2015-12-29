using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public partial class DatabaseConnection
    {
        public SqlConnection conn = null;
        public SqlDataReader rdr = null;

        public void Connect()
        {
            //string connectionString = Library.Properties.Settings.Default.ConnectionString;   -- powinno automatycznie wylapywac conn stringa, ale nie dziala :(

            conn = new SqlConnection("Data Source=(local); Initial Catalog=Library; Integrated Security=SSPI");

            conn.Open();
        }

        public string Test()
        {
            SqlCommand PrintUsers = new SqlCommand("select * from Users", conn);
            string napis = "";

            rdr = PrintUsers.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    for (int i = 0; i < 8; i++)
                    {  
                       napis = napis + rdr[i] + " ";
                    }

                    napis += "\n";
                }
            }

            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }

            return napis;
        }
    }
}
