using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace MiniFrota.Models
{
    public class Emplacamento 
    {
        [Key]
        [Required(ErrorMessage = "Informe a placa do veiculo")]
        [Display(Name = "Placas")]
        public string Placas { get; set; }

        [Required(ErrorMessage = "Informe a data do emplacamento")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy }", ApplyFormatInEditMode = true)]
        [DisplayName("DataVencimento")]
        public DateTime DataVencimento { get; set; }

        [Required(ErrorMessage = "Informe o valor emplacamento")]
        [Display(Name = "ValorEmplacamento")]
        [Column(TypeName ="decimal(10,2)")]
        public decimal ValorEmplacamento { get; set; }
    }
}