using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Emplacamento : Veiculo
    {
        [Required(ErrorMessage = "Informe a data do emplacamento")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataVencimento { get; set; }

        [Required(ErrorMessage = "Informe o valor emplacamento")]
        [Display(Name = "ValorEmplacamento")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(999,99,ErrorMessage ="O preço deve estar entre 1000,00 e 29999,99")]
        public decimal ValorEmplacamento { get; set; }
    }
}