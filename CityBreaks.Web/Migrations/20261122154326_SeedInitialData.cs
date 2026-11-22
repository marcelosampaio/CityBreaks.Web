using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CityBreaks.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CountryName" },
                values: new object[,]
                {
                    { 1, "BR", "Brasil" },
                    { 2, "PT", "Portugal" },
                    { 3, "FR", "França" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Brasília" },
                    { 2, 1, "Rio de Janeiro" },
                    { 3, 2, "Lisboa" },
                    { 4, 2, "Porto" },
                    { 5, 3, "Paris" },
                    { 6, 3, "Lyon" }
                });

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "CityId", "InterestPoint", "PricePerNight" },
                values: new object[,]
                {
                    { 1, 1, "Hotel Brasília Central", 350.00m },
                    { 2, 2, "Copacabana Palace", 1200.00m },
                    { 3, 3, "Hotel Avenida Palace", 650.00m },
                    { 4, 4, "PortoBay Flores", 580.00m },
                    { 5, 5, "Hôtel des Arts", 750.00m },
                    { 6, 6, "Hôtel de Lyon", 420.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
