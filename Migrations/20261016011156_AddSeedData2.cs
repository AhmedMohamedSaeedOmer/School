using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "Id", "Name", "age", "salary", "school_id", "schooolId" },
                values: new object[,]
                {
                    { 1, "Ahmed Mohamed Saeed Omer", 23, 20000000m, 0, null },
                    { 2, "Ahmed Mohamed Omer", 24, 50000000m, 0, null },
                    { 3, " Mohamed Saeed Omer", 24, 80000000m, 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
