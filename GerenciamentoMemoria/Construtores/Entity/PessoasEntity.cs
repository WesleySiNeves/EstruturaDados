using Construtores.Base;
using Construtores.Construtor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Entity
{
    public class PessoasEntity : BaseEntity
    {



        /// <summary>
        /// Campo chave para tabela [Cadastro].[Pessoas]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(250)]
        public string NomeRazaoSocial { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeSocialFantasia { get; set; }



        [DataMember]
        [Required]
        public bool TipoPessoaFisica { get; set; }




        /// <summary>
        /// Tamanho maximo 20 caracteres
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string CPFCNPJ { get; set; }




        /// <summary>
        /// Tamanho maximo 30 caracteres
        /// </summary>
        [DataMember]
        [StringLength(30)]
        public string RGIE { get; set; }




        /// <summary>
        /// Texto livre
        /// </summary>
        [DataMember]
        public string Observacao { get; set; }



        [DataMember]
        public DateTime? DataCriacao { get; set; }



        [DataMember]
        public DateTime? DataAtualizacao { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string EnderecoSite { get; set; }



        [DataMember]
        [Required]
        public int FlagsBitwisePessoa { get; set; }



        [DataMember]
        [Required]
        public bool VisivelSomenteSiscaf { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeUsuarioChancela { get; set; }



        [DataMember]
        public DateTime? DataChancela { get; set; }



        [DataMember]
        [Required]
        public bool Estrangeiro { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }



        [DataMember]
        [Required]
        public int EspecializacaoValor { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeUsuarioCriacao { get; set; }




        /// <summary>
        /// Tamanho maximo 60 caracteres
        /// </summary>
        [DataMember]
        [StringLength(60)]
        public string NomeUnidadeCriacao { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeUsuarioAtualizacao { get; set; }




        /// <summary>
        /// Tamanho maximo 60 caracteres
        /// </summary>
        [DataMember]
        [StringLength(60)]
        public string NomeUnidadeAtualizacao { get; set; }



        [DataMember]
        public bool? EnderecoSitePublico { get; set; }



        [DataMember]
        [Required]
        public int PreferenciaCorrespondencia { get; set; }




        /// <summary>
        /// Tamanho maximo 30 caracteres
        /// </summary>
        [DataMember]
        [StringLength(30)]
        public string Codigo { get; set; }




        /// <summary>
        /// Tamanho maximo 200 caracteres
        /// </summary>
        [DataMember]
        [StringLength(200)]
        public string NomeRazaoSocialSemPreposicao { get; set; }




        /// <summary>
        /// Tamanho maximo 20 caracteres
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string CPFCNPJSomenteNumeros { get; set; }




        /// <summary>
        /// Tamanho maximo 1000 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1000)]
        public string TermoConsulta { get; set; }
    }

}
