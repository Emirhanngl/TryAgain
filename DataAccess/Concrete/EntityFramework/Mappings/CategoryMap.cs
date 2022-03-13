using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable(@"Categories", @"dbo");
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("ID");
            Property(x => x.CategoryName).HasColumnName("CategoryName");
            Property(x => x.Description).HasColumnName("Description");
        }
    }
}
