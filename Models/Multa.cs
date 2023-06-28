using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Multa
    {
        [Key]
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string Gravidade { get; set; }
        public string Local { get; set; }
        public DateTime DataMulta { get; set; }
        
        public Motorista Mot { get; set; }
        public Veiculo Veic { get; set; }
    }
}