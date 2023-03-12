using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using moviewebsite.Entities.Abstract;

namespace moviewebsite.Entities.EntityTypeConfig.Abstract
{
    public class Basemap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate)
                .HasColumnName("CreateDate")
                .HasColumnType("datetime2")
                .IsRequired(true);

            builder.Property(x => x.UpdateDate)
                .HasColumnName("UpdateDate")
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder.Property(x => x.DeleteDate)
                .HasColumnName("DeleteDate")
                .HasColumnType("datetime2")
                .IsRequired(false);

            builder.Property(x => x.Status)
                .HasColumnName("Status")
                .IsRequired(true);

            builder.HasQueryFilter(p => p.Status == Status.Active || p.Status == Status.Modified);
        }
    }
}
