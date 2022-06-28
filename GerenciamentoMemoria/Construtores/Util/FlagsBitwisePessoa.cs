using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    /// <summary>
    /// Atributos de uma pessoa que são guardados no campo FlagsBitwisePessoa da tabela de pessoas
    /// </summary>
    [Flags]
    [DataContract]
    public enum FlagsBitwisePessoa
    {

        /// <summary>
        /// Nenhum atributo atvado
        /// </summary>
        [EnumMember]
        None = 0,


        /// <summary>
        /// Indica que uma pessoa recebe por Credito em ficha de compempensação
        /// </summary>
        [EnumMember]
        CreditoFichaCompensacao = 1,

        /// <summary>
        /// Indica que uma pessoa recebe e-mails do Conselho
        /// </summary>
        [EnumMember]
        RecebeEmails = 2,

        /// <summary>
        /// Indica que uma pessoa recebe revistas do Conselho
        /// </summary>
        [EnumMember]
        RecebeRevistas = 4,

        /// <summary>
        /// Indica que uma pessoa utiliza PIX
        /// </summary>
        [EnumMember]
        UtilizaPIX = 8,

        /// <summary>
        /// Indica se a pessoa possui restrição
        /// </summary>
        [EnumMember]
        PossuiRestricao = 16
    }
}
