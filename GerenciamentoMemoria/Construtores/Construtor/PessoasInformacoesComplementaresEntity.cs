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
    public partial class PessoasInformacoesComplementaresEntity : BaseEntity
    {

        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaInformacaoComplementar;
            }
            set
            {
                IdPessoaInformacaoComplementar = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasInformacoesComplementares]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaInformacaoComplementar { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string DescricaoFlagBitWiseRestricao { get; set; }


        #endregion
    }
}
