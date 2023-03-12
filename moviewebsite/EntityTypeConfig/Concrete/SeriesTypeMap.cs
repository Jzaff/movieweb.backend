using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class SeriesTypeMap : Basemap<SeriesType>
    {
        public override void Configure(EntityTypeBuilder<SeriesType> builder)
        {
            builder.Property(x => x.Explanation).HasMaxLength(50);
            base.Configure(builder);
        }
    }
}
