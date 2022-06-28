using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Construtor
{
    public enum LocalEndereco
    {
        [Description("Alternativo")]
        Alternativo = 0,

        [Description("Residencial")]
        Residencial = 1,

        [Description("Comercial")]
        Comercial = 2,

        [Description("Funcionamento")]
        Funcionamento = 3
    }
}
