using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;

namespace Construtores.Construtor
{
	[DataContract]
    [Serializable]
    public partial class DadosBancariosEntity : BaseEntity
    {

        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdDadoBancario;
            }
            set
            {
                IdDadoBancario = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[DadosBancarios]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdDadoBancario { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public Guid IdBanco { get; set; }



        [DataMember]
        [Required]
        public bool DebitoEmConta { get; set; }



        [DataMember]
        [Required]
        public bool ContaCorrente { get; set; }




        /// <summary>
        /// Tamanho maximo 10 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(10)]
        public string AgenciaCodigo { get; set; }




        /// <summary>
        /// Tamanho maximo 2 caracteres
        /// </summary>
        [DataMember]
        [StringLength(2)]
        public string AgenciaDV { get; set; }




        /// <summary>
        /// Tamanho maximo 10 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(10)]
        public string ContaNumero { get; set; }




        /// <summary>
        /// Tamanho maximo 2 caracteres
        /// </summary>
        [DataMember]
        [StringLength(2)]
        public string ContaDV { get; set; }




        /// <summary>
        /// Tamanho maximo 4 caracteres
        /// </summary>
        [DataMember]
        [StringLength(4)]
        public string ContaOperacao { get; set; }




        /// <summary>
        /// Texto livre
        /// </summary>
        [DataMember]
        public string Observacao { get; set; }



        [DataMember]
        [Required]
        public DateTime DataAtualizacao { get; set; }



        [DataMember]
        [Required]
        public bool Padrao { get; set; }

        #endregion


        #region Partial

        [DataMember]
        public BancosEntity Banco { get; set; }

        [DataMember]
        public string AgenciaFormatado { get; set; }

        [DataMember]
        public string ContaFormatado { get; set; }


        [DataMember]
        public string TipoConta { get; set; }

        #endregion
    }
}
