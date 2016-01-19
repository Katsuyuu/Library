using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Windows;
using System.Data;
using System.Data.SqlClient;
using Library.Database;

namespace Library
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryEntities : DbContext
    {
        public LibraryEntities()
            : base("name=LibraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BorrowController> BorrowController { get; set; }
        public virtual DbSet<Publishers> Publishers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
