using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFrota.Migrations
{
    /// <inheritdoc />
    public partial class oitava : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Multas",
                newName: "ValorMulta");

            migrationBuilder.RenameColumn(
                name: "Placa",
                table: "Multas",
                newName: "PlacVeiculo");

            migrationBuilder.RenameColumn(
                name: "Local",
                table: "Multas",
                newName: "LocalMulta");

            migrationBuilder.AlterColumn<int>(
                name: "Nome",
                table: "Motoristas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldMaxLength: 80)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorMulta",
                table: "Multas",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "PlacVeiculo",
                table: "Multas",
                newName: "Placa");

            migrationBuilder.RenameColumn(
                name: "LocalMulta",
                table: "Multas",
                newName: "Local");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Motoristas",
                type: "varchar(80)",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
