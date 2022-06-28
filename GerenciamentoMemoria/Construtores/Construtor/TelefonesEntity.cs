using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;
using Construtores.Construtor.Interfaces;
using Construtores.Util;

namespace Construtores.Construtor
{
    public class TelefonesEntity : BaseEntity, IMonitoravelEntity
    {
        #region Auto

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdTelefone;
            }
            set
            {
                IdTelefone = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[Telefones]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdTelefone { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public bool Comercial { get; set; }




        /// <summary>
        /// Tamanho maximo 20 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(20)]
        public string Telefone { get; set; }




        /// <summary>
        /// Tamanho maximo 4 caracteres
        /// </summary>
        [DataMember]
        [StringLength(4)]
        public string Ramal { get; set; }




        /// <summary>
        /// Texto livre
        /// </summary>
        [DataMember]
        public string Complemento { get; set; }



        [DataMember]
        [Required]
        public bool Fax { get; set; }



        [DataMember]
        [Required]
        public int Tipo { get; set; }



        [DataMember]
        [Required]
        public bool Publico { get; set; }



        [DataMember]
        public DateTime? DataAtualizacao { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeUsuarioCriacao { get; set; }



        [DataMember]
        public DateTime? DataCriacao { get; set; }




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
        [Required]
        public bool Atualizado { get; set; }


        #endregion


        #region Partial

        public TelefonesEntity()
        {
            Publico = false;
        }

        public TipoTelefone TipoTelefone
        {
            get
            {
                return (TipoTelefone)this.Tipo;
            }
        }

        public string TipoTelefoneDescription
        {
            get
            {
                return TipoTelefone.GetDescription();
            }
        }

        #endregion
    }
}
