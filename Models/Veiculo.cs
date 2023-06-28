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
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Locado { get; set; }
        public string NomeLocadora { get; set; }
        public Manutencao Manut { get; set; }

        public ICollection<Motorista> Motoristas { get; set; }
        public ICollection<Multa> Multas { get; set; }
    }
}