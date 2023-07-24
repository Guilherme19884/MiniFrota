using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFrota.Models
{
    public abstract class Base
    {
        [Required, MaxLength(80, ErrorMessage = "Nome deve ter no máximo 80 caracteres")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }


        [EmailAddress]
        [Display(Name = "Email")]
        [Required, MaxLength(120)]
        public string email { get; set; }

        [Required, MaxLength(16, ErrorMessage = "Senha deve ter no máximo 16 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string senha { get; set; }
    }
}