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
    public partial class PessoasUnidadesEntity : BaseEntity
    {

        #region Auto

        

        

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaUnidade;
            }
            set
            {
                IdPessoaUnidade = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasUnidades]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaUnidade { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public Guid IdUnidade { get; set; }



        [DataMember]
        [Required]
        public DateTime DataCadastro { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }



        [DataMember]
        [Required]
        public bool UsuarioPadrao { get; set; }



        [DataMember]
        [Required]
        public bool UnidadePadrao { get; set; }

        #endregion

        #region Partial

        public PessoasUnidadesEntity()
        {
            Pessoa = new PessoasEntity();
            Ativo = true;
        }

        [DataMember]
        public UnidadesEntity Unidade { get; set; }

        [DataMember]
        public PessoasEntity Pessoa { get; set; }

        #endregion
    }
}
