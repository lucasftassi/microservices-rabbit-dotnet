using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace microservices_rabbit.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Key", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 3L, "Tecnologia", "Laptop da Apple", "abc123", "Macbook", 9999m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Key", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 4L, "Saúde", "Bicicleta para pedalar", "abc123", "Bicicleta", 10000m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Key", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 5L, "Limpeza", "Para tirar a gordura da cozinha", "abc123", "Desengordurante", 8.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Key",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Key",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Key",
                keyValue: 5L);
        }
    }
}
