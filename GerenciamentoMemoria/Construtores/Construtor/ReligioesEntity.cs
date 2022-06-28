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
    public class ReligioesEntity : BaseEntity
    {

        #region  Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdReligiao;
            }
            set
            {
                IdReligiao = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[Religioes]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdReligiao { get; set; }




        /// <summary>
        /// Tamanho maximo 100 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }


        #endregion


        #region  Partial

        public ReligioesEntity()
        {
            Ativo = true;
        }

        #endregion
    }
}
