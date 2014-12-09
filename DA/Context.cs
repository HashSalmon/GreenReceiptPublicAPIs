using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Domain.Objects;
using MySql.Data.MySqlClient;

namespace DA
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptItem> ReceiptItems { get; set; }
        public DbSet<Store> Stores { get; set; }

        public Context()
#if RELEASE
            : base(new MySqlConnection("Server=54.148.225.22;Database=greenreceipt;Uid=root;Pwd=agrit817!!@@##"), true)
#elif ALEX
            : base(new MySqlConnection("Server=127.0.0.1;Database=greenreceipt;Uid=root;Pwd=Aa8175014"), true)
#else
            : base(new MySqlConnection("Server=127.0.0.1;Database=greenreceipt;Uid=root;Pwd=zheng"), true)
#endif
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof (Receipt)));
        }
    }
}
