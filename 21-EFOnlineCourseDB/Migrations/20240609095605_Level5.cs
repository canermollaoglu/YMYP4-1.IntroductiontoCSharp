using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _21_EFOnlineCourseDB.Migrations
{
    /// <inheritdoc />
    public partial class Level5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Registration",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Registration");
        }
    }
}
