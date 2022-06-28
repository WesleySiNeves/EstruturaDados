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
    public partial class PessoasGruposPessoasEntity : BaseEntity
    {


        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaGrupoPessoa;
            }
            set
            {
                IdPessoaGrupoPessoa = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasGruposPessoas]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaGrupoPessoa { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public Guid IdGrupoPessoa { get; set; }



        [DataMember]
        [Required]
        public DateTime DataCadastro { get; set; }

        #endregion

        #region Partial

        public PessoasGruposPessoasEntity()
        {
            GrupoPessoa = new GruposPessoasEntity();
        }

        /// <summary>
        /// Define o grupo da pessoa
        /// /// </summary>
        [DataMember]
        public GruposPessoasEntity GrupoPessoa { get; set; }


        [DataMember]
        public string NomeRazaoSocial { get; set; }

        [DataMember]
        public string CPFCNPJ { get; set; }

        [DataMember]
        public string TipoPessoaExtenso { get; set; }

        #endregion
    }
}
