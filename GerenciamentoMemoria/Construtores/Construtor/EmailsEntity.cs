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
    public class EmailsEntity : BaseEntity
    {


        #region Auto

        

        
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdEmail;
            }
            set
            {
                IdEmail = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[Emails]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdEmail { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public bool Comercial { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(250)]
        public string Email { get; set; }




        /// <summary>
        /// Texto livre
        /// </summary>
        [DataMember]
        public string Complemento { get; set; }



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
        public bool Correspondencia { get; set; }



        [DataMember]
        [Required]
        public bool Atualizado { get; set; }

        #endregion


        #region Partial

        public EmailsEntity()
        {
            Publico = false;
        }

        #endregion
    }
}
