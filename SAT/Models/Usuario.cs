using System.ComponentModel.DataAnnotations;

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
        public string CPF { get; set; }

        public string Plano { get; set; }

        public string CodCliente { get; set; }


    }
}
