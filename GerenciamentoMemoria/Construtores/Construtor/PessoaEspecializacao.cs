using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Construtor
{
    /// <summary>
    /// FlagsBitwise Indicam quais especializações de "Pessoa" um registro possui
    /// </summary>
    [Flags]
    [DataContract]
    public enum PessoaEspecializacao
    {
        /// <summary>
        /// 0 = Uma pessoa genérica base, não especializada
        /// Não pode haver nenhum registro no banco que seja somente uma "Pessoa" sem especializar
        /// </summary>
        [Description("Pessoa")]
        [EnumMember]
        Pessoa = 0,

        /// <summary>
        /// 1 = Pessoa Física Comum
        /// </summary>
        [Description("Pessoa Física")]
        [EnumMember]
        PessoaFisica = 1,

        /// <summary>
        /// 2 = Pessoa Jurídica Comun
        /// </summary>
        [Description("Pessoa Jurídica")]
        [EnumMember]
        PessoaJuridica = 2,

        /// <summary>
        /// 4 = Usuário no Sistema
        /// </summary>
        [Description("Usuário no Sistema")]
        [EnumMember]
        Usuario = 4,

        /// <summary>
        /// 8 = Profissional Registrado no Conselho
        /// </summary>
        [Description("Profissional")]
        [EnumMember]
        ProfissionalRegistrado = 8,

        /// <summary>
        /// 16 = Empresa Registrada no Conselho
        /// </summary>
        [Description("Empresa")]
        [EnumMember]
        EmpresaRegistrada = 16,

        /// <summary>
        /// 32 = Instituição de Ensino
        /// </summary>
        [Description("Instituição de Ensino")]
        [EnumMember]
        InstituicaoEnsino = 32,


        /// <summary>
        /// 64 = Aluno do CURSOS.NET
        /// </summary>
        [Description("Aluno do CURSOS.NET")]
        [EnumMember]
        Aluno = 64,

        /// <summary>
        /// 128 = Professor do CURSOS.NET
        /// </summary>
        [Description("Professor do CURSOS.NET")]
        [EnumMember]
        Professor = 128,


        /// <summary>
        /// 256 = Conselhos Regionais
        /// </summary>
        [Description("Conselhos Regionais")]
        [EnumMember]
        Conselho = 256,

        /// <summary>
        /// 512 = Estagiários
        /// </summary>
        [Description("Estagiário")]
        [EnumMember]
        Estagiario = 512

    }
}
