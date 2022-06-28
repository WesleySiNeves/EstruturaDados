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
    public partial class TiposEntidadesEntity : BaseEntity
    {

        #region  Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdTipoEntidade;
            }
            set
            {
                IdTipoEntidade = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[TiposEntidades]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdTipoEntidade { get; set; }




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




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string CodigoIntegracaoFederal { get; set; }

        #endregion


        #region Partial

        public TiposEntidadesEntity()
        {
            Ativo = true;
        }

        #endregion
    }
}
