using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniFrota.Context;
using MiniFrota.Models;

namespace MiniFrota.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly AppDbContext _context;

        public VeiculoRepository(AppDbContext Context)
        {
            _context = Context;
        }
        public Veiculo GetById(string placa)
        {
            Veiculo veiculo = _context.Veiculos.Find(placa);
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
            return veiculo;

        }

        public List<Veiculo> GetAll()
        {
            var veiculos = _context.Veiculos.ToList();
            return veiculos;
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
        }

        public void UpdateVeiculo(string placa)
        {
            var veiculo = _context.Veiculos.Find(placa);
            _context.Veiculos.Add(veiculo);
        }

        public void DeleteVeiculo(string placa)
        {
            var veiculo = _context.Veiculos.Find(placa);

            _context.Veiculos.Remove(veiculo);
            _context.SaveChanges();
        }

        public Veiculo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateVeiculo(Veiculo veiculo)
        {
            throw new NotImplementedException();
        }
    }

}