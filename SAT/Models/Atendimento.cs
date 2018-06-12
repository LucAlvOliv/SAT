using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Atendimento
    {
        public int AtendimentoID { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Problema { get; set; }
    }
}
