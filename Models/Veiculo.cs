using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Veiculo
    {
        [Key]
        [Required(ErrorMessage = "O campo Placa é obrigatório.")]
        [Display(Name = "Placa")]
        public string Placa { get; set; }


        [Required(ErrorMessage = "O campo Cor é obrigatório.")]
        [Display(Name = "Cor")]
        public string Cor { get; set; }


        [Required(ErrorMessage = "O campo Marca é obrigatório.")]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "O campo Modelo é obrigatório.")]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; }
        
        public Manutencao Manut { get; set; }

        public ICollection<Motorista> Motoristas { get; set; }
        public ICollection<Multa> Multas { get; set; }
    }
}