using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class CategoryMap : Basemap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.Explanation).HasMaxLength(600).IsRequired(true);
            builder.HasIndex(x => x.CategoryName).IsUnique(true);
            base.Configure(builder);
        }
    }
}
