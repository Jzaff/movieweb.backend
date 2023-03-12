using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class MovieMap : Basemap<Movie>
    {
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(x => x.MovieName).HasMaxLength(45);
            builder.HasIndex(x => x.MovieName).IsUnique(true);
            builder.Property(x => x.MovieType).HasMaxLength(50);
            builder.HasIndex(x => x.MovieType).IsUnique(true);
            base.Configure(builder);
        }
    }
}
