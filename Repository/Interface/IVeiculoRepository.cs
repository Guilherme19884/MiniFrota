using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniFrota.Models;

namespace MiniFrota.Repository
{
    public interface IVeiculoRepository
    {
        Veiculo GetById(int id);
        List<Veiculo> GetAll();
        void AdicionarVeiculo(Veiculo veiculo);
        void UpdateVeiculo(Veiculo veiculo);
        void DeleteVeiculo(string placa);
    }
}