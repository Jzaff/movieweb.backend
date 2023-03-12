using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class SeriesMap : Basemap<Series>
    {
        public override void Configure(EntityTypeBuilder<Series> builder)
        {
            builder.Property(x => x.SeriesName).HasMaxLength(45);
            builder.HasIndex(x => x.SeriesName).IsUnique(true);
            builder.Property(x => x.SeriesType).HasMaxLength(50);
            builder.HasIndex(x => x.SeriesType).IsUnique(true);
            base.Configure(builder);
        }
    }
}
