using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Blog.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Article>().Property(x=>x.Title).HasMaxLength(150);
            //üstteki gibi kullanım da var ama iyi değil
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Assembly.. olmasının sebebi IEntityTypeConfiguration<Article>'dan kalıtım alan tüm sınıflar metotlar hepsine uygulanabilir olması. Tek tek uygulamıyoruz.
        }
    }
}
