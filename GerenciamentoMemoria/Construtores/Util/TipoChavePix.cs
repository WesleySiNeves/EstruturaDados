using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    public enum TipoChavePix
    {
        [Description("Telefone")]
        Telefone = 1,
        [Description("Email")]
        Email = 2,
        [Description("CPF/CNPJ")]
        CPF_CNPJ = 3,
        [Description("Chave aleatória")]
        ChaveAleatoria = 4,
        [Description("Dados bancários")]
        DadosBancarios = 5,
    }
}
