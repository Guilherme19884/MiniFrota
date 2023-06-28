using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniFrota.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Combustiveis",
                columns: table => new
                {
                    CombustivelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCombustivel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorCombustivel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataAbastecimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KmAtual = table.Column<long>(type: "bigint", nullable: false),
                    KmAbastecimentoAnterior = table.Column<long>(type: "bigint", nullable: false),
                    ValorTotalAbastecimentoMes = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combustiveis", x => x.CombustivelId);
                });

            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalEmplacamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAbastecimentoAno = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSeguro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MultaAno = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalManutencao = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manutencoes",
                columns: table => new
                {
                    ManutencaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataUltimaManutencao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataProximaManutencao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorManutencao = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DescricaoServico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manutencoes", x => x.ManutencaoId);
                });

            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {
                    SeguroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroApolice = table.Column<long>(type: "bigint", nullable: false),
                    ValorSeguro = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FimVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Franquia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorFranquia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CNPJ = table.Column<long>(type: "bigint", nullable: false),
                    NomeSeguradora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeCorretoraSeguros = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.SeguroId);
                });

            migrationBuilder.CreateTable(
                name: "Sinistros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locado = table.Column<bool>(type: "bit", nullable: false),
                    NomeLocadora = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManutencaoId = table.Column<int>(type: "int", nullable: true),
                    CombustivelId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeguroId = table.Column<int>(type: "int", nullable: true),
                    DataVencimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ValorEmplacamento = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Placa);
                    table.ForeignKey(
                        name: "FK_Veiculos_Combustiveis_CombustivelId",
                        column: x => x.CombustivelId,
                        principalTable: "Combustiveis",
                        principalColumn: "CombustivelId");
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
                });

            migrationBuilder.CreateTable(
                name: "Admistradores",
                columns: table => new
                {
                    AdmistradorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotoristaId = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admistradores", x => x.AdmistradorId);
                });

            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    MotoristaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroCnh = table.Column<long>(type: "bigint", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AdmistradorId = table.Column<int>(type: "int", nullable: true),
                    VeiculoPlaca = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    email = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    senha = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Multas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gravidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataMulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotoristaId = table.Column<int>(type: "int", nullable: true),
                    VeicPlaca = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                });

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
                name: "IX_Veiculos_CombustivelId",
                table: "Veiculos",
                column: "CombustivelId");

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
