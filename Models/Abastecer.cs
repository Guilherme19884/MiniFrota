using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Abastecer
    {
        [Key]
        public int AbastecerId { get; set; }
        public string TipoCombustivel { get; set; }
        public decimal ValorCombustivel { get; set; }
        public DateTime DataAbastecimento { get; set; }
        public long KmAtual { get; set; }
        public long KmAbastecimentoAnterior { get; set; }
        public decimal ValorTotalAbastecimentoMes { get; set; }

        public ICollection<Veiculo>Veiculos { get; set; }
    }
}