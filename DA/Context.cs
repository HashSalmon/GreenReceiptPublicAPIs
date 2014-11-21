using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Objects;
using MySql.Data.MySqlClient;

namespace DA
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; } 

        public Context()
            : base(new MySqlConnection("Server=localhost;Database=greenreceipt;Uid=root;Pwd=Aa8175014;"), true)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
        }
    }
}
