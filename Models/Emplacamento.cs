using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Emplacamento : Veiculo
    {
        public DateTime DataVencimento { get; set; }
        public decimal ValorEmplacamento { get; set; }
    }
}