using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class TvshowsMap : Basemap<Tvshows>
    {
        public override void Configure(EntityTypeBuilder<Tvshows> builder)
        {
            builder.Property(x => x.TvshowName).HasMaxLength(45);
            builder.HasIndex(x => x.TvshowName).IsUnique(true);
            builder.Property(x => x.TvshowType).HasMaxLength(50);
            builder.HasIndex(x => x.TvshowType).IsUnique(true);
            base.Configure(builder);
        }
    }
}
