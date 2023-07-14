using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFrota.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Combustiveis",
                columns: table => new
                {
                    AbastecerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoCombustivel = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorCombustivel = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DataAbastecimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    KmAtual = table.Column<long>(type: "bigint", nullable: false),
                    KmAbastecimentoAnterior = table.Column<long>(type: "bigint", nullable: false),
                    ValorTotalAbastecimentoMes = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combustiveis", x => x.AbastecerId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalEmplacamento = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalAbastecimentoAno = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalSeguro = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MultaAno = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalManutencao = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Manutencoes",
                columns: table => new
                {
                    ManutencaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataManutencao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataProximaManutencao = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    KmDiaManutencao = table.Column<long>(type: "bigint", nullable: false),
                    ValorManutencao = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DescricaoServico = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pecasSubstituidas = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencoes", x => x.ManutencaoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {
                    SeguroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroApolice = table.Column<long>(type: "bigint", nullable: false),
                    ValorSeguro = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FimVigencia = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Franquia = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorFranquia = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CNPJ = table.Column<long>(type: "bigint", nullable: false),
                    NomeSeguradora = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeCorretoraSeguros = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.SeguroId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sinistros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataHora = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SeguroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinistros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sinistros_Seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguros",
                        principalColumn: "SeguroId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Marca = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Locado = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NomeLocadora = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ManutencaoId = table.Column<int>(type: "int", nullable: true),
                    AbastecerId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SeguroId = table.Column<int>(type: "int", nullable: true),
                    DataVencimento = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ValorEmplacamento = table.Column<decimal>(type: "decimal(65,30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Placa);
                    table.ForeignKey(
                        name: "FK_Veiculos_Combustiveis_AbastecerId",
                        column: x => x.AbastecerId,
                        principalTable: "Combustiveis",
                        principalColumn: "AbastecerId");
                    table.ForeignKey(
                        name: "FK_Veiculos_Manutencoes_ManutencaoId",
                        column: x => x.ManutencaoId,
                        principalTable: "Manutencoes",
                        principalColumn: "ManutencaoId");
                    table.ForeignKey(
                        name: "FK_Veiculos_Seguros_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguros",
                        principalColumn: "SeguroId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Admistradores",
                columns: table => new
                {
                    AdmistradorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MotoristaId = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admistradores", x => x.AdmistradorId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    MotoristaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroCnh = table.Column<long>(type: "bigint", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    AdmistradorId = table.Column<int>(type: "int", nullable: true),
                    VeiculoPlaca = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoristas", x => x.MotoristaId);
                    table.ForeignKey(
                        name: "FK_Motoristas_Admistradores_AdmistradorId",
                        column: x => x.AdmistradorId,
                        principalTable: "Admistradores",
                        principalColumn: "AdmistradorId");
                    table.ForeignKey(
                        name: "FK_Motoristas_Veiculos_VeiculoPlaca",
                        column: x => x.VeiculoPlaca,
                        principalTable: "Veiculos",
                        principalColumn: "Placa");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Multas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Gravidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Local = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataMulta = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MotoristaId = table.Column<int>(type: "int", nullable: true),
                    VeicPlaca = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multas_Motoristas_MotoristaId",
                        column: x => x.MotoristaId,
                        principalTable: "Motoristas",
                        principalColumn: "MotoristaId");
                    table.ForeignKey(
                        name: "FK_Multas_Veiculos_VeicPlaca",
                        column: x => x.VeicPlaca,
                        principalTable: "Veiculos",
                        principalColumn: "Placa");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Admistradores_MotoristaId",
                table: "Admistradores",
                column: "MotoristaId");

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_AdmistradorId",
                table: "Motoristas",
                column: "AdmistradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Motoristas_VeiculoPlaca",
                table: "Motoristas",
                column: "VeiculoPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_Multas_MotoristaId",
                table: "Multas",
                column: "MotoristaId");

            migrationBuilder.CreateIndex(
                name: "IX_Multas_VeicPlaca",
                table: "Multas",
                column: "VeicPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_Sinistros_SeguroId",
                table: "Sinistros",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_AbastecerId",
                table: "Veiculos",
                column: "AbastecerId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ManutencaoId",
                table: "Veiculos",
                column: "ManutencaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_SeguroId",
                table: "Veiculos",
                column: "SeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admistradores_Motoristas_MotoristaId",
                table: "Admistradores",
                column: "MotoristaId",
                principalTable: "Motoristas",
                principalColumn: "MotoristaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admistradores_Motoristas_MotoristaId",
                table: "Admistradores");

            migrationBuilder.DropTable(
                name: "Dashboards");

            migrationBuilder.DropTable(
                name: "Multas");

            migrationBuilder.DropTable(
                name: "Sinistros");

            migrationBuilder.DropTable(
                name: "Motoristas");

            migrationBuilder.DropTable(
                name: "Admistradores");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Combustiveis");

            migrationBuilder.DropTable(
                name: "Manutencoes");

            migrationBuilder.DropTable(
                name: "Seguros");
        }
    }
}
