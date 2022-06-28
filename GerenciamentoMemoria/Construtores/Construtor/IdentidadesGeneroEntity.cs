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
	public partial class IdentidadesGeneroEntity : BaseEntity
    {

        #region Auto

        

       

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdIdentidadeGenero;
            }
            set
            {
                IdIdentidadeGenero = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[IdentidadesGenero]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdIdentidadeGenero { get; set; }




        /// <summary>
        /// Tamanho maximo 40 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(40)]
        public string Nome { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }


        #endregion
    }
}
