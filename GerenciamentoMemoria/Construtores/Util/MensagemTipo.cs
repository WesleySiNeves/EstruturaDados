using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    public enum MensagemTipo
    {
        [EnumMember(Value = "Erro")] Erro,
        [EnumMember(Value = "Aviso")] Aviso,
        [EnumMember(Value = "Interno")] Interno,
        [EnumMember(Value = "Sucesso")] Sucesso,
        [EnumMember(Value = "Dica")] Dica,
    }
}
