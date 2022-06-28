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
    public partial class TiposBasicosEntity : BaseEntity
    {

        #region Auto




        [DataMember]
        public override Guid Id
        {
            get { return IdTipo; }
            set { IdTipo = value; }
        }




        /// <summary>
        /// Campo chave para tabela [Corporativo].[TiposBasicos]
        /// </summary>
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



        [DataMember] [Required] public bool Ativo { get; set; }

        #endregion


        #region Partial


        /// <summary>
        /// Define o lista de itens do tipo
        /// </summary>
        [DataMember]
        public List<TiposBasicosItensEntity> ItensTipo { get; set; }

        #endregion

    }
}
