using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Motorista : Base
    {
        [Key]
        public int MotoristaId { get; set; }
        public long NumeroCnh { get; set; }
        public decimal Salario { get; set; }
    }
}