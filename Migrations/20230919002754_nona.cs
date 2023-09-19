using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFrota.Migrations
{
    /// <inheritdoc />
    public partial class nona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Seguro",
                table: "Sinistros",
                newName: "ApoliceSeguroSeguro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApoliceSeguroSeguro",
                table: "Sinistros",
                newName: "Seguro");
        }
    }
}
