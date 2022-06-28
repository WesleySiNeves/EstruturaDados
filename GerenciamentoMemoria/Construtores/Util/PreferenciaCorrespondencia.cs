using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    public enum PreferenciaCorrespondencia
    {

        [Description("Receber por Correio")]
        ReceberPorCorreio = 1,

        [Description("Receber por Email")]
        ReceberPorEmail = 2
    }
}
