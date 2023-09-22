using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("E1D2ECCE-C8C2-424D-862C-EFC2231F65F0"),
                    Name = "ASP.Net Core",
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,

                },
                 new Category
                 {
                     Id = Guid.Parse("04FA9184-BA37-40ED-9B30-3FBA0D792D2B"),
                     Name = "Visual Studiop",
                     CreatedBy = "Admin Test",
                     CreatedDate = DateTime.Now,
                     IsDeleted = false
                 });
        }
    }
}
