using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    public enum BooleanOption
    {
        [Description("Todos")] All,
        [Description("Sim")] True,
        [Description("Não")] False,
    }
}
