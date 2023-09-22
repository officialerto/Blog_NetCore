using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedcompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("04fa9184-ba37-40ed-9b30-3fba0d792d2b"), "Admin Test", new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8860), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual Studiop" },
                    { new Guid("e1d2ecce-c8c2-424d-862c-efc2231f65f0"), "Admin", new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8856), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.Net Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("88b6b6f5-2eaf-4b9f-b31b-afb206eff4fe"), "Admin Test", new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8963), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage", "jpg", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef9b73a3-cc3a-43c6-a68c-9f37592a55dc"), "Admin Test", new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8961), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "images/testimage", "jpg", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("33aacc7c-0832-46b5-bc15-56bab4634251"), new Guid("e1d2ecce-c8c2-424d-862c-efc2231f65f0"), "Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd ", "Admin", new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8690), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef9b73a3-cc3a-43c6-a68c-9f37592a55dc"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASP.Net Core Makalesi", 15 },
                    { new Guid("a998df51-3aba-4de3-ba92-076b1eda183d"), new Guid("04fa9184-ba37-40ed-9b30-3fba0d792d2b"), "Visual  Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd Bck Doıqweqıop Axqjadqıo Öaıwq Asd ", "Admin", new DateTime(2023, 9, 22, 19, 26, 20, 46, DateTimeKind.Local).AddTicks(8695), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88b6b6f5-2eaf-4b9f-b31b-afb206eff4fe"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Visual studio deneme makalesi", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("33aacc7c-0832-46b5-bc15-56bab4634251"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a998df51-3aba-4de3-ba92-076b1eda183d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04fa9184-ba37-40ed-9b30-3fba0d792d2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e1d2ecce-c8c2-424d-862c-efc2231f65f0"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("88b6b6f5-2eaf-4b9f-b31b-afb206eff4fe"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ef9b73a3-cc3a-43c6-a68c-9f37592a55dc"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
