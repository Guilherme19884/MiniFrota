using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Manutencao
    {
        [Key]
        public int ManutencaoId { get; set; }
        public DateTime DataUltimaManutencao { get; set; }
        public DateTime DataProximaManutencao { get; set; }
        public decimal ValorManutencao { get; set; }
        public string  DescricaoServico { get; set; }

        public ICollection<Veiculo> Veiculos { get; set; }
    }
}