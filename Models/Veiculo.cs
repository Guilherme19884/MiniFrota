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
        public string Placa { get; set; }

         [Required(ErrorMessage = "O campo Cor é obrigatório.")]
        public string Cor { get; set; }

         [Required(ErrorMessage = "O campo Marca é obrigatório.")]
        public string Marca { get; set; }

         [Required(ErrorMessage = "O campo Modelo é obrigatório.")]
        public string Modelo { get; set; }
        public bool Locado { get; set; }
        public string NomeLocadora { get; set; }
        public Manutencao Manut { get; set; }

        public ICollection<Motorista> Motoristas { get; set; }
        public ICollection<Multa> Multas { get; set; }
    }
}