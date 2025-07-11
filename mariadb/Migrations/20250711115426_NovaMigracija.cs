using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mariadb.Migrations
{
    /// <inheritdoc />
    public partial class NovaMigracija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CijenaGoriva",
                table: "Goriva",
                type: "decimal(5,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<decimal>(
                name: "KilometriNaRegistraciji",
                table: "Automobili",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "CijenaGoriva",
                table: "Goriva",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,1)");

            migrationBuilder.AlterColumn<decimal>(
                name: "KilometriNaRegistraciji",
                table: "Automobili",
                type: "decimal(10,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");
        }
    }
}
