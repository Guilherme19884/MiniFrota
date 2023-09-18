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

        [Required(ErrorMessage = "Informe o nome do Motorista.")]
        [Display(Name = "Nome")]
        public int Nome{ get; set; }

        [Required(ErrorMessage = "Informe sua CNH.")]
        [Display(Name = "NumeroCnh")]
        public long NumeroCnh { get; set; }

        [Required(ErrorMessage = "Informe o salário do Motorista.")]
        [Display(Name = "Salario")]
        [Range(1.800,99,ErrorMessage ="O salário deve estar entre 1.199,99 e 5.999,99")]
        public decimal Salario { get; set; }
    }
}