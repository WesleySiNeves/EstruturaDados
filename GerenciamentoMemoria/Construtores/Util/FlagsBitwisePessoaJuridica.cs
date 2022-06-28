using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    /// <summary>
    /// Atributos de uma pessoa juridica que são guardados no campo FlagsBitwisePessoaJiridica da tabela de pessoasJusiridas
    /// </summary>
    [Flags]
    [DataContract]
    public enum FlagsBitwisePessoaJuridica
    {
        /// <summary>
        /// Nenhum atributo atvado
        /// </summary>
        [EnumMember]
        None = 0,

        /// <summary>
        /// Indica que a Pessoa juridica é uma Companhia aérea
        /// </summary>
        [EnumMember]
        CompanhiaAerea = 1,

        /// <summary>
        /// Indica que a Pessoa juridica é uma Associação
        /// </summary>
        [EnumMember]
        Associacao = 2,

        /// <summary>
        /// Indica que a Pessoa juridica é uma Entidade de Classe
        /// </summary>
        [EnumMember]
        EntidadeClasse = 4,

        /// <summary>
        /// Indica que a Pessoa juridica é uma Empresa de viação
        /// </summary>
        [EnumMember]
        EmpresaViacao = 8,

        /// <summary>
        /// Indica que a Pessoa juridica é Imune(Informação usada na Dirf) 
        /// </summary>
        [EnumMember]
        Imune = 16,

        /// <summary>
        /// Indica que a Pessoa juridica é Isenta(Informação usada na Dirf) 
        /// </summary>
        [EnumMember]
        Isento = 32,

        /// <summary>
        /// Indica se a Pessoa Juridica é ME ou EPP(Micro-Empresa ou Empresa de Pequeno Porte)
        /// </summary>
        [EnumMember]
        MEouEPP = 64

    }
}
