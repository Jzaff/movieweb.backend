using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class MovieTypeMap : Basemap<MovieType>
    {
        public override void Configure(EntityTypeBuilder<MovieType> builder)
        {
            builder.Property(x => x.Explanation).HasMaxLength(50);
            base.Configure(builder);
        }
    }
}
