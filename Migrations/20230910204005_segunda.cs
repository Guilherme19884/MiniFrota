using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFrota.Migrations
{
    /// <inheritdoc />
    public partial class segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContatoCorretor",
                table: "Seguros");

            migrationBuilder.DropColumn(
                name: "DataVencimento",
                table: "Multas");

            migrationBuilder.DropColumn(
                name: "NomeMotorista",
                table: "Motoristas");

            migrationBuilder.AddColumn<string>(
                name: "Seguro",
                table: "Sinistros",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Placa",
                table: "Multas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seguro",
                table: "Sinistros");

            migrationBuilder.DropColumn(
                name: "Placa",
                table: "Multas");

            migrationBuilder.AddColumn<string>(
                name: "ContatoCorretor",
                table: "Seguros",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataVencimento",
                table: "Multas",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NomeMotorista",
                table: "Motoristas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
