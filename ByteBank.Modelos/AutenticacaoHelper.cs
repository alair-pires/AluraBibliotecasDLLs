﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class AutenticacaoHelper
    {
        public bool CompararSenhas(string senha, string tentativa)
        {
            return senha == tentativa;
        }
    }
}
