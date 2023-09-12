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

        [Required(ErrorMessage = "Informe a data da multa.")]
        [Display(Name = "DataMulta")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataMulta { get; set; }

        [Required(ErrorMessage = "Informe o local da nulta.")]
        [Display(Name = "LocalDaMulta")]
        public string Local { get; set; }

        [Required(ErrorMessage = "Informe a gravidade da infração cometida.")]
        [Display(Name = "Gravidade")]
        public string Gravidade { get; set; }

        [Required(ErrorMessage = "Informe o valor da multa.")]
        [Display(Name = "ValorMulta")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Informe a data da vencimento.")]
        [Display(Name = "DataVencimento")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataVencimento { get; set; }


        //[Required(ErrorMessage = "Informe o nome do motorista.")]
       // [Display(Name = "QualMotorista")]
       // public Motorista Mot { get; set; } talvez na v2.0

        [Required(ErrorMessage = "Informe a placa do veiculo.")]
        [Display(Name = "PlacVeiculo")]
        public string Placa { get; set; }
        //public Veiculo Veic { get; set; } futura implementação talvez na v2.0
    }
}