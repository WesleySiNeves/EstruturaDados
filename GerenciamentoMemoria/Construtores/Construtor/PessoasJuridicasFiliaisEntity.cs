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
    public partial class PessoasJuridicasFiliaisEntity : BaseEntity
    {

        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaJuridicaFilial;
            }
            set
            {
                IdPessoaJuridicaFilial = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasJuridicasFiliais]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaJuridicaFilial { get; set; }



        [DataMember]
        [Required]
        public Guid IdMatriz { get; set; }



        [DataMember]
        [Required]
        public Guid IdFilial { get; set; }


        #endregion


        #region Partial

        [DataMember]
        public PessoasEntity Matriz { get; set; }

        [DataMember]
        public PessoasEntity Filial { get; set; }

        #endregion
    }
}
