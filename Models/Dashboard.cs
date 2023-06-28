using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Dashboard
    {
        public int Id { get; set; }
        public decimal Total{ get; set; }
        public decimal TotalEmplacamento { get; set; }
        public decimal TotalAbastecimentoAno { get; set; }
        public decimal TotalSeguro { get; set;}
        public decimal MultaAno { get; set; }
        public decimal TotalManutencao { get; set; }
    }
}