using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;
using Construtores.Util;

namespace Construtores.Construtor
{
    public class ChavesPixEntity : BaseEntity
    {
        #region Auto

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdChavePix;
            }
            set
            {
                IdChavePix = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[ChavesPix]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdChavePix { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }



        [DataMember]
        [Required]
        public int TipoChave { get; set; }




        /// <summary>
        /// Tamanho maximo 72 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(72)]
        public string Chave { get; set; }



        [DataMember]
        [Required]
        public bool Padrao { get; set; }

        #endregion


        #region Partial

        public string TipoChaveDescription => ((TipoChavePix)TipoChave).GetDescription();



        #endregion
    }
}
