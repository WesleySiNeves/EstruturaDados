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
	public partial class TiposDeficienciasEntity : BaseEntity
    {

        #region Auto

        

       

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdTipoDeficiencia;
            }
            set
            {
                IdTipoDeficiencia = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[TiposDeficiencias]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdTipoDeficiencia { get; set; }




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
    }
}
