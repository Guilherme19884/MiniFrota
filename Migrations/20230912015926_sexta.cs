using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFrota.Migrations
{
    /// <inheritdoc />
    public partial class sexta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Seguros");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoCombustivel",
                table: "Combustiveis",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CNPJ",
                table: "Seguros",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecoCombustivel",
                table: "Combustiveis",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");
        }
    }
}
