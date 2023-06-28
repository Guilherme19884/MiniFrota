using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Seguro
    {
        
        public int SeguroId { get; set; }
        public long NumeroApolice { get; set; }
        public decimal ValorSeguro { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime FimVigencia { get; set; }
        public string Franquia { get; set; } //Duvidas futuras aqui
        public decimal ValorFranquia { get; set; }
        public long CNPJ { get; set; }
        public string NomeSeguradora { get; set; }
        public string NomeCorretoraSeguros { get; set; }
        public ICollection<Veiculo>Veiculos { get; set; }

        
        public void AdicionarCobertura(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
        }

        public void RemoverCobertura(Veiculo veiculo)
        {
           Veiculos.Remove(veiculo);;
        }
    }
}