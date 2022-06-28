using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    /// <summary>
    /// Atributos de uma pessoa física que são guardados no campo FlagsBitwisePessoaFisica da tabela de pessoasFisicas
    /// </summary>
    [Flags]
    [DataContract]
    public enum FlagsBitwisePessoaFisica
    {
        /// <summary>
        /// Nenhum atributo atvado
        /// </summary>
        [EnumMember]
        None = 0,
    }
}
