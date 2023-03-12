using Microsoft.EntityFrameworkCore;
using moviewebsite.Entities.Abstract;
using moviewebsite.Entities.Concrete;
using System.Reflection;

namespace moviewebsite.Entities.Context
{
    public class SqlDbcontext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Tvshows> Tvshowss { get; set; }
        public DbSet<Signup> Signups { get; set; }
        public DbSet<MovieType> MovieTypes { get; set; }
        public DbSet<MoviePhoto> MoviePhotos { get; set; }
        public DbSet<SeriesType> SeriesTypes { get; set; }
        public DbSet<SeriesPhoto> SeriesPhotos { get; set; }
        public DbSet<TvshowType> TvshowTypes { get; set; }
        public DbSet<TvshowPhoto> TvshowPhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MsSqlLocalDb;Database=TekelOtomasyon;Integrated Security=true;TrustServerCertificate=True");
        }
        public SqlDbcontext()
        {

        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            UpdateSoftDeleteStatuses();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        private void UpdateSoftDeleteStatuses()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["Status"] = Status.Active;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["Status"] = Status.Passive;
                        entry.CurrentValues["DeleteDate"] = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["Status"] = Status.Modified;
                        entry.CurrentValues["UpdateDate"] = DateTime.Now;

                        break;
                }
            }
        }
    }
}
