using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Atendimento
    {
        [Key]
        public int AtendimentoID { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        public string Problema { get; set; }
    }
}
