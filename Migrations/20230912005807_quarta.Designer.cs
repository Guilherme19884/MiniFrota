﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniFrota.Context;

#nullable disable

namespace MiniFrota.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230912005807_quarta")]
    partial class quarta
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MiniFrota.Models.Abastecer", b =>
                {
                    b.Property<int>("AbastecerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAbastecimento")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("KmAtual")
                        .HasColumnType("bigint");

                    b.Property<decimal>("PrecoCombustivel")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("QuantidadeLitros")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("TipoCombustivel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("ValorAbastecimento")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("AbastecerId");

                    b.ToTable("Combustiveis");
                });

            modelBuilder.Entity("MiniFrota.Models.Admistrador", b =>
                {
                    b.Property<int>("AdmistradorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("MotoristaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.HasKey("AdmistradorId");

                    b.HasIndex("MotoristaId");

                    b.ToTable("Admistradores");
                });

            modelBuilder.Entity("MiniFrota.Models.Dashboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("MultaAno")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalAbastecimentoAno")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalEmplacamento")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalManutencao")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalSeguro")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Dashboards");
                });

            modelBuilder.Entity("MiniFrota.Models.Emplacamento", b =>
                {
                    b.Property<string>("Placas")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ValorEmplacamento")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Placas");

                    b.ToTable("Emplacamentos");
                });

            modelBuilder.Entity("MiniFrota.Models.Manutencao", b =>
                {
                    b.Property<int>("ManutencaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataManutencao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataProximaManutencao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoServico")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("KmDiaManutencao")
                        .HasColumnType("bigint");

                    b.Property<decimal>("ValorManutencao")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("pecasSubstituidas")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ManutencaoId");

                    b.ToTable("Manutencoes");
                });

            modelBuilder.Entity("MiniFrota.Models.Motorista", b =>
                {
                    b.Property<int>("MotoristaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AdmistradorId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<long>("NumeroCnh")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.HasKey("MotoristaId");

                    b.HasIndex("AdmistradorId");

                    b.ToTable("Motoristas");
                });

            modelBuilder.Entity("MiniFrota.Models.Multa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataMulta")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Gravidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Multas");
                });

            modelBuilder.Entity("MiniFrota.Models.Seguro", b =>
                {
                    b.Property<int>("SeguroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<long>("CNPJ")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("FimVigencia")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Franquia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeCorretoraSeguros")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeSeguradora")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("NumeroApolice")
                        .HasColumnType("bigint");

                    b.Property<decimal>("ValorFranquia")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("ValorSeguro")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("SeguroId");

                    b.ToTable("Seguros");
                });

            modelBuilder.Entity("MiniFrota.Models.Sinistro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Seguro")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Sinistros");
                });

            modelBuilder.Entity("MiniFrota.Models.Veiculo", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Placa");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("MiniFrota.Models.Admistrador", b =>
                {
                    b.HasOne("MiniFrota.Models.Motorista", "Motorista")
                        .WithMany()
                        .HasForeignKey("MotoristaId");

                    b.Navigation("Motorista");
                });

            modelBuilder.Entity("MiniFrota.Models.Motorista", b =>
                {
                    b.HasOne("MiniFrota.Models.Admistrador", null)
                        .WithMany("Motoristas")
                        .HasForeignKey("AdmistradorId");
                });

            modelBuilder.Entity("MiniFrota.Models.Admistrador", b =>
                {
                    b.Navigation("Motoristas");
                });
#pragma warning restore 612, 618
        }
    }
}