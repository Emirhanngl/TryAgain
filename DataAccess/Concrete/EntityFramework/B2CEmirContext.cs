using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using System.Data.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class B2CEmirContext : DbContext
    {
        public B2CEmirContext() : base("B2CEmirContext")
        {
            Database.SetInitializer<B2CEmirContext>(null);
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());

        }
    }
}
