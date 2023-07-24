using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Abastecer
    {
        [Key]
        public int AbastecerId { get; set; }

        [Required(ErrorMessage = "Informe o Combustível que irá abastecer")]
        [StringLength(50)]
        [Display(Name = "Combustível")]
        public string TipoCombustivel { get; set; }

        [Required(ErrorMessage = "Informe o valor")]
        [Display(Name = "Valor")]
        public decimal ValorCombustivel { get; set; }

        [Required(ErrorMessage = "Informe a data do abastecimento")]
        [Display(Name = "DataAbastecimeto")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Text)]
        public DateTime DataAbastecimento { get; set; }

        [Required(ErrorMessage = "Informe a KM do abastecimento")]
        [Display(Name = "KmAtual")]
        public long KmAtual { get; set; }

        [Required(ErrorMessage = "Informe a KM abastecimento anterior")]
        [Display(Name = "KmAnterior")]
        public long KmAbastecimentoAnterior { get; set; }

        [Required(ErrorMessage = "Informe o preço do combustivel")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal PrecoCombustivel { get; set; }    


        [Required(ErrorMessage = "Informe o valor total do abastecimento")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal ValorTotalAbastecimento { get; set; }

        
    }
}