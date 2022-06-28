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
    public partial class BairrosEntity : BaseEntity
    {

        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdBairro;
            }
            set
            {
                IdBairro = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Corporativo].[Bairros]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdBairro { get; set; }



        [DataMember]
        [Required]
        public Guid IdCidade { get; set; }




        /// <summary>
        /// Tamanho maximo 100 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }

        #endregion
    }
}
