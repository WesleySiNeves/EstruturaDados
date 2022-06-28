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
    public class PessoasAreasAtuacoesEntity : BaseEntity
    {
		#region Auto

		[DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaAreaAtuacao;
            }
            set
            {
                IdPessoaAreaAtuacao = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasAreasAtuacoes]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaAreaAtuacao { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public Guid IdAreaAtuacao { get; set; }

        #endregion

        #region Partial

        [DataMember]
        public AreasAtuacoesEntity AreaAtuacao { get; set; }

        #endregion
    }
}
