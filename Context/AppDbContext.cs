using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniFrota.Models;

namespace MiniFrota.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Admistrador> Admistradores { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }   
        public DbSet<Manutencao> Manutencoes { get; set; }
        public DbSet<Multa> Multas { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Combustivel> Combustiveis { get; set; }
        public DbSet<Emplacamento> Emplacamentos { get; set; }
        public DbSet<Sinistro>Sinistros { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
    }
}