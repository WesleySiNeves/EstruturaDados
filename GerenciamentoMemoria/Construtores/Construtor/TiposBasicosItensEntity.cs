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
    public partial class TiposBasicosItensEntity : BaseEntity
    {

        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdTipoItem;
            }
            set
            {
                IdTipoItem = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Corporativo].[TiposBasicosItens]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdTipoItem { get; set; }



        [DataMember]
        [Required]
        public Guid IdTipo { get; set; }




        /// <summary>
        /// Tamanho maximo 100 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string CodigoIntegracaoFederal { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }

        #endregion


        #region  Partial


        /// <summary>
        /// Define o tipo básico do objeto
        /// </summary>
        [DataMember]
        public TiposBasicosEntity TipoBasico { get; set; }

        #endregion
    }
}
