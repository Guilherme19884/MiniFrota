using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFrota.Migrations
{
    /// <inheritdoc />
    public partial class setima : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sinistros",
                keyColumn: "Seguro",
                keyValue: null,
                column: "Seguro",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Seguro",
                table: "Sinistros",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Seguro",
                table: "Sinistros",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
