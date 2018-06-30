using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class AtendimentoCliente
    {
        [Key]
        public int AtendimentoID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        public string Plano { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        public string CodCliente { get; set; }
        
        [Required]
        public string Problema { get; set; }
    }
}
