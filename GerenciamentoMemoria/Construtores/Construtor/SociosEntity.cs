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
    public class SociosEntity : BaseEntity
    {

		#region Auto

		[DataMember]
        public override Guid Id
        {
            get
            {
                return IdSocio;
            }
            set
            {
                IdSocio = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[Socios]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdSocio { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }



        [DataMember]
        public Guid? IdCargo { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string Telefone { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string Email { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }




        /// <summary>
        /// Tamanho maximo 100 caracteres
        /// </summary>
        [DataMember]
        [StringLength(100)]
        public string CapitalSocial { get; set; }

        #endregion


        #region Partail

        [DataMember]
        public CargosEntity Cargo { get; set; }

        #endregion
    }
}
