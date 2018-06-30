using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        public string Plano { get; set; }

        [Required]
        public string CodCliente { get; set; }


    }
}
