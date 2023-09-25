using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Manutencao
    {
        [Key]
        public int ManutencaoId { get; set; }

        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy }", ApplyFormatInEditMode = true)]
        [Display(Name = "DataManutencao")]
        public DateTime DataManutencao { get; set; }

        [Required(ErrorMessage = "Informe o Km do dia da manutenção")]
        [Display(Name = "KmDiaManutencao")]
        public long KmDiaManutencao { get; set; }

        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy }", ApplyFormatInEditMode = true)]
        [Display(Name = "DataProximaManutencao")]
        public DateTime DataProximaManutencao { get; set; }

        [Required(ErrorMessage = "Informe o valor da manutenção")]
        [Display(Name = "ValorManutencao")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1.999,99,ErrorMessage ="O preço deve estar entre 1 e 9999,99")]
        public decimal ValorManutencao { get; set; }

        [Required(ErrorMessage = "Informe as peças substituídas")]
        [Display(Name = "pecasSubstituidas")]
        public string pecasSubstituidas { get; set; }
        
        [Required(ErrorMessage = "Informe a descrição do serviço")]
        [Display(Name = "DescricaoServico")]
        public string  DescricaoServico { get; set; }
        
    }
}