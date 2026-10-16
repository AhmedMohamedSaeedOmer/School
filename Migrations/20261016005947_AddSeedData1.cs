using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "schoools",
                columns: new[] { "Id", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 2, "Assuit", "EL-Kawthar", "language " },
                    { 3, "Assuit", "Futur", "International " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "schoools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "schoools",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
