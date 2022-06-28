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
    public partial class OrientacoesSexuaisEntity : BaseEntity
    {

        #region Auto

        

      

        [DataMember]
        public override Guid Id
        {
            get { return IdOrientacaoSexual; }
            set { IdOrientacaoSexual = value; }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[OrientacoesSexuais]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdOrientacaoSexual { get; set; }




        /// <summary>
        /// Tamanho maximo 40 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(40)]
        public string Nome { get; set; }



        [DataMember] [Required] public bool Ativo { get; set; }

        #endregion
    }
}
