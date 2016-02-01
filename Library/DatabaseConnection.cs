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
        public static LibraryEntities DBConnection = new LibraryEntities();

    }
}
