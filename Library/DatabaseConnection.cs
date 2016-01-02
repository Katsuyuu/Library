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
        public static SqlConnection conn = null;
        public static SqlDataReader rdr = null;

        public DatabaseConnection()
        {
            conn = new SqlConnection("Data Source=(local); Initial Catalog=Library; Integrated Security=SSPI");

            conn.Open();
        }

        public string Test()
        {
            SqlCommand printUsers = new SqlCommand("select FirstName, LastName, \"Index\" from Users", conn);
            string napis = "";

            rdr = printUsers.ExecuteReader();
            try
            {
                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.VisibleFieldCount; i++)
                    {  
                       napis = napis + rdr[i] + " - ";
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
            }

            return napis;
        }
    }
}
