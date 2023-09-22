using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "ASP.Net Core Makalesi",
                    Content = "Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd ",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("E1D2ECCE-C8C2-424D-862C-EFC2231F65F0"),
                    ImageId = Guid.Parse("EF9B73A3-CC3A-43C6-A68C-9F37592A55DC"),
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,

                },

                new Article
                {

                    Id = Guid.NewGuid(),
                    Title = "Visual studio deneme makalesi",
                    Content = "Visual  Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd ",
                    ViewCount = 15,
                    CategoryId = Guid.Parse("04FA9184-BA37-40ED-9B30-3FBA0D792D2B"),
                    ImageId = Guid.Parse("88B6B6F5-2EAF-4B9F-B31B-AFB206EFF4FE"),
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,

                });
        }
    }
}
