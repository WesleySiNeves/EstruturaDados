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
    public class PessoasTiposEntidadesEntity : BaseEntity
    {

        #region  Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaTipoEntidade;
            }
            set
            {
                IdPessoaTipoEntidade = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasTiposEntidades]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaTipoEntidade { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public Guid IdTipoEntidade { get; set; }


        #endregion


        #region Partial

        [DataMember]
        public TiposEntidadesEntity TipoEntidade { get; set; }


        #endregion
    }
}
