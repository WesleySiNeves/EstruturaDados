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
    public partial class AreasAtuacoesEntity : BaseEntity
    {
        #region Auto

        

      

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdAreaAtuacao;
            }
            set
            {
                IdAreaAtuacao = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[AreasAtuacoes]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdAreaAtuacao { get; set; }




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

        public AreasAtuacoesEntity()
        {
            Ativo = true;
        }

        #endregion
    }
}
