using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;
using Construtores.Entity;

namespace Construtores.Construtor
{
	[DataContract]
    [Serializable]
    public partial class ResponsaveisEntity : BaseEntity
    {
        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdResponsavel;
            }
            set
            {
                IdResponsavel = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[Responsaveis]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdResponsavel { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }



        [DataMember]
        [Required]
        public int Atribuicoes { get; set; }


        #endregion

        #region Partial


        public ResponsaveisEntity()
        {
            ResponsaveisUnidades = new List<ResponsaveisUnidadesEntity>();
        }

        [DataMember]
        public PessoasEntity Pessoa { get; set; }

        [DataMember]
        public List<ResponsaveisUnidadesEntity> ResponsaveisUnidades { get; set; }

        [DataMember]
        public int QuantidadeUnidadesResponsavel { get; set; }

        #endregion
    }
}
