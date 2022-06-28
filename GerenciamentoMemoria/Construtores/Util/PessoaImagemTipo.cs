using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    public enum PessoaImagemTipo
    {
        [Description("Foto")]
        Foto = 1,

        [Description("Assinatura")]
        Assinatura = 2,

        [Description("Digital")]
        Digital = 3,

        [Description("Logomarca")]
        Logomarca = 4
    }
}
