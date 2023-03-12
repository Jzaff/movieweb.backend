using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class HomeMap : Basemap<Home>
    {
        public override void Configure(EntityTypeBuilder<Home> builder)
        {
            builder.Property(x => x.TopExplanation).HasMaxLength(200);
            builder.HasIndex(x => x.TopExplanation).IsUnique(true);
            builder.Property(x => x.allpack).HasMaxLength(500);
            base.Configure(builder);
        }
    }
}
