﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        public string Nome { get; set; }

        public int CPF { get; set; }

        public string Plano { get; set; }
    }
}
