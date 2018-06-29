using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class AtendimentoCliente
    {
        [Key]
        public int AtendimentoID { get; set; }

        public string Nome { get; set; }
        
        [Required]
        public string Problema { get; set; }
    }
}
