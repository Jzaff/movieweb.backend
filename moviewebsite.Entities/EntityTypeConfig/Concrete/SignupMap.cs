using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Concrete;
using moviewebsite.Entities.EntityTypeConfig.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Concrete
{
    public class SignupMap : Basemap<Signup>
    {
        public override void Configure(EntityTypeBuilder<Signup> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(25);
            builder.Property(x => x.Surname).HasMaxLength(50);
            builder.Property(x => x.Username).HasMaxLength(50);
            builder.Property(x => x.Password).HasMaxLength(50);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Gsm).HasMaxLength(50);
            base.Configure(builder);
        }
    }
}
