using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Product", @"dbo");
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("ID");
            Property(x => x.CategoryID).HasColumnName("CategoryID");
            Property(x => x.ProductName).HasColumnName("ProductName");
            Property(x => x.Description).HasColumnName("Description");
            Property(x => x.Price).HasColumnName("Price");
            Property(x => x.Stock).HasColumnName("Stock");
        }
    }
}
