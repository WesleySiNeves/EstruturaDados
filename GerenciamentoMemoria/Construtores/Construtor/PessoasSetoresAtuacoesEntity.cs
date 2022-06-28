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
    public class PessoasSetoresAtuacoesEntity : BaseEntity
    {

        #region Auto

        

      
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaSetorAtuacao;
            }
            set
            {
                IdPessoaSetorAtuacao = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasSetoresAtuacoes]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaSetorAtuacao { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public Guid IdSetorAtuacao { get; set; }

        #endregion


        #region Partial


        public SetoresAtuacoesEntity SetorAtuacao { get; set; }

        #endregion
    }
}
