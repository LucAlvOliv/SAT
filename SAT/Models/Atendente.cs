using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Atendente
    {
        [Key]
        public int AtendenteID { get; set; }

        [Required]
        [StringLength(30)]
        public string Usuario { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
