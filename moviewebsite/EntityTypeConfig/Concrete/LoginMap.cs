using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class LoginMap : Basemap<Login>
    {
        public override void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.Property(x => x.Email).HasMaxLength(70);
            builder.Property(x => x.Password).HasMaxLength(70);
            base.Configure(builder);
        }
    }
}
