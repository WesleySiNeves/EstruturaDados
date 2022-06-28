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
    public partial class BancosEntity : BaseEntity
    {

        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdBanco;
            }
            set
            {
                IdBanco = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Corporativo].[Bancos]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdBanco { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(250)]
        public string Nome { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(250)]
        public string Site { get; set; }




        /// <summary>
        /// Tamanho maximo 10 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(10)]
        public string CodigoCompensacao { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }


        #endregion
    }
}
