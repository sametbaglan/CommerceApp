using CommerceApp.Models.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CommerceApp.DbConnection
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3IKQL6T\SQLEXPRESS;Database=CommerceDb;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         

        }
        public DbSet<User> users { get; set; }
        public DbSet<userRole> userRoles { get; set; }
        public DbSet<Category> categories { get; set; }

        public DbSet<Varyants> Varyants { get; set; }

        public DbSet<Attribute> attributes { get; set; }
        public DbSet<AttributeValues> attributeValues { get; set; }
 
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductAttributeValue> productAttributeValues { get; set; }
    }
}
