using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Sinistro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Descreva a ocorrência")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a data do sinsistro")]
        [Display(Name = "DataHora")]
        public DateTime DataHora { get; set; }

        [Required(ErrorMessage = "Informe a apolice do seguro")]
        [Display(Name = "ApoliceSeguro")]
        public string ApoliceSeguroSeguro { get; set; }
    }
}