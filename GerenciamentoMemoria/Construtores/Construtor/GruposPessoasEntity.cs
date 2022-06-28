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
    public partial class GruposPessoasEntity : BaseEntity
    {
        #region Auto

        

       

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdGrupoPessoa;
            }
            set
            {
                IdGrupoPessoa = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[GruposPessoas]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdGrupoPessoa { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(250)]
        public string Nome { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }

        #endregion


        #region Partial

        public GruposPessoasEntity()
        {
            ListaPessoasGrupo = new List<PessoasGruposPessoasEntity>();
        }

        /// <summary>
        /// Atributo Criado para carregar as pessoas do grupo
        /// </summary>
        [DataMember]
        public List<PessoasGruposPessoasEntity> ListaPessoasGrupo { get; set; }

        #endregion
    }
}
