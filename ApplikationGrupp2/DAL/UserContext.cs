using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ApplikationGrupp2.Models;

namespace ApplikationGrupp2.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base("Databas_Applikation")
        {
        }
        //testing testing!! Death to the infidels! TAKBIIIIR!!!
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}