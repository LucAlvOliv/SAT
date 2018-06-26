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
        //[StringLength(10)]
        public string Senha { get; set; }
    }
}
