using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Atendimento
    {
        [Key]
        public int AtendimentoID { get; set; }

        public int ClienteID { get; set; }
        public virtual Cliente _Cliente { get; set; }


        //public int AtendenteID { get; set; }
        //public virtual Atendente _Atendente { get; set; }


        [Required]
        public string Problema { get; set; }
    }
}
