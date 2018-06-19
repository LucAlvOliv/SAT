using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public int CPF { get; set; }

        public string Plano { get; set; }

        public string Endereco { get; set; }

        public int CEP { get; set; }


    }
}
