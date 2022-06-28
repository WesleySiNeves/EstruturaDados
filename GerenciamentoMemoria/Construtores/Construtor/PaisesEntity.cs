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
    public class PaisesEntity : BaseEntity
    {
        #region Auto

        

        
        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(250)]
        public string Nome { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string Gentilico { get; set; }




        /// <summary>
        /// Tamanho maximo 3 caracteres
        /// </summary>
        [DataMember]
        [StringLength(3)]
        public string Sigla { get; set; }
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdPais;
            }
            set
            {
                IdPais = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Corporativo].[Paises]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPais { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeUsuarioChancela { get; set; }



        [DataMember]
        public DateTime? DataChancela { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string CodigoIntegracaoFederal { get; set; }




        /// <summary>
        /// Tamanho maximo 200 caracteres
        /// </summary>
        [DataMember]
        [StringLength(200)]
        public string JustificativaChancela { get; set; }

        #endregion


        #region Partial


        public PaisesEntity()
        {
            Ativo = true;
        }

        public void Inativar()
        {
            Ativo = false;
        }

        #endregion
    }
}
