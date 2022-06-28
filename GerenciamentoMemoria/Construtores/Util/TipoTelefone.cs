using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    public enum TipoTelefone
    {
        [Description("Comercial")]
        Comercial = 0,

        [Description("Residencial")]
        Residencial = 1,

        [Description("Celular pessoal")]
        CelularPessoal = 2,

        [Description("Celular comercial")]
        CelularComercial = 3,

        [Description("Recado")]
        Recado = 4,

        [Description("Fax")]
        Fax = 5,

        [Description("Funcionamento")]
        Funcionamento = 6,

        [Description("Outros")]
        Outros = 7
    }
}
