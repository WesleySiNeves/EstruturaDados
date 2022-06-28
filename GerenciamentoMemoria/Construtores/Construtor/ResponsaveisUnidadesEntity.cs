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
    public partial class ResponsaveisUnidadesEntity : BaseEntity
    {

        #region Auto

        

        

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdResponsavelUnidade;
            }
            set
            {
                IdResponsavelUnidade = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[ResponsaveisUnidades]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdResponsavelUnidade { get; set; }



        [DataMember]
        [Required]
        public Guid IdResponsavel { get; set; }



        [DataMember]
        [Required]
        public Guid IdUnidade { get; set; }



        [DataMember]
        [Required]
        public bool ResponsavelPadrao { get; set; }

        #endregion


        #region Partial

        [DataMember]
        public UnidadesEntity Unidade { get; set; }

        [DataMember]
        public ResponsaveisEntity Responsavel { get; set; }

        #endregion
    }
}
