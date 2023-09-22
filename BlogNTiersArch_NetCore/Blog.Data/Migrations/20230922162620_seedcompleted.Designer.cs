﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230922162620_seedcompleted")]
    partial class seedcompleted
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("33aacc7c-0832-46b5-bc15-56bab4634251"),
                            CategoryId = new Guid("e1d2ecce-c8c2-424d-862c-efc2231f65f0"),
                            Content = "Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd ",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8690),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = new Guid("ef9b73a3-cc3a-43c6-a68c-9f37592a55dc"),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "ASP.Net Core Makalesi",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("a998df51-3aba-4de3-ba92-076b1eda183d"),
                            CategoryId = new Guid("04fa9184-ba37-40ed-9b30-3fba0d792d2b"),
                            Content = "Visual  Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd ",
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8695),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageId = new Guid("88b6b6f5-2eaf-4b9f-b31b-afb206eff4fe"),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Visual studio deneme makalesi",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e1d2ecce-c8c2-424d-862c-efc2231f65f0"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8856),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "ASP.Net Core"
                        },
                        new
                        {
                            Id = new Guid("04fa9184-ba37-40ed-9b30-3fba0d792d2b"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8860),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Visual Studiop"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ef9b73a3-cc3a-43c6-a68c-9f37592a55dc"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8961),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("88b6b6f5-2eaf-4b9f-b31b-afb206eff4fe"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8963),
                            DeletedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}