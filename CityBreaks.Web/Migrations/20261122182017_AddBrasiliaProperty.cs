using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityBreaks.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddBrasiliaProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "CityId", "InterestPoint", "PricePerNight" },
                values: new object[] { 7, 1, "Pousada Vila Planalto", 280.00m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
