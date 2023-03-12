using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class TvshowTypeMap : Basemap<TvshowType>
    {
        public override void Configure(EntityTypeBuilder<TvshowType> builder)
        {
            builder.Property(x => x.Explanation).HasMaxLength(50);
            base.Configure(builder);
        }
    }
}
