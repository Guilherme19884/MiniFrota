using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public class Admistrador : Base
    {
        [Key]
        public int AdmistradorId { get; set; }
        public Motorista Motorista { get; set; }
        public ICollection<Motorista>Motoristas { get; set; }

        public void AdicionarMotorista (Motorista motorista)
        {
            Motoristas.Add(motorista);
        }

        public void RemoverMotorista (Motorista motorista)
        {
            Motoristas.Remove(motorista);
        }
    }
}