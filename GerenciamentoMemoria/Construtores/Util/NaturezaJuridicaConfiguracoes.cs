using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    /// <summary>
    /// Atributos de uma natureza jurídica
    /// </summary>
    [Flags]
    public enum NaturezaJuridicaConfiguracoes
    {

        None = 0,

        [Description("Ativo")]
        Ativo = 1,

        [Description("Isenção Financeira")]
        IsencaoFinanceira = 2

    }
}
