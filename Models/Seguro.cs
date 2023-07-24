using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Seguro
    {
        
        public int SeguroId { get; set; }

        [Required(ErrorMessage = "Informe o número da apolice.")]
        [Display(Name = "NumeroApolice")]
        public long NumeroApolice { get; set; }


        [Required(ErrorMessage = "Informe informe o valor do seguro.")]
        [Display(Name = "ValorSeguro")]
        [Column(TypeName ="decimal(10,2)")]
        public decimal ValorSeguro { get; set; }


        [Required(ErrorMessage = "Informe a data de inicio da vigência.")]
        [Display(Name = "DataInicio")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataInicio { get; set; }


        [Required(ErrorMessage = "Informe a gravidade da infração cometida.")]
        [Display(Name = "FimVigencia")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FimVigencia { get; set; }


        [Required(ErrorMessage = "Informe o valor da franquia.")]
        [Display(Name = "Franquia")]        
        public string Franquia { get; set; } //Duvidas futuras aqui

        [Required(ErrorMessage = "Informe o valor da franquia.")]
        [Display(Name = "ValorFranquia")]
        [Column(TypeName ="decimal(10,2)")]
        public decimal ValorFranquia { get; set; }
        
        [Required(ErrorMessage = "Informe o CNPJ da seguradora (somente números).")]
        [Display(Name = "CNPJ")]
        public long CNPJ { get; set; }

        [Required(ErrorMessage = "Informe o nome da seguradora.")]
        [Display(Name = "NomeSeguradora")]
        public string NomeSeguradora { get; set; }

        [Required(ErrorMessage = "Informe o nome da corretora de seguros.")]
        [Display(Name = "NomeCorretoraSeguros")]
        public string NomeCorretoraSeguros { get; set; }
        public ICollection<Veiculo>Veiculos { get; set; }

        
        public void AdicionarCobertura(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);
        }

        public void RemoverCobertura(Veiculo veiculo)
        {
           Veiculos.Remove(veiculo);;
        }
    }
}