using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;
using Construtores.Construtor.Interfaces;

namespace Construtores.Construtor
{
	[DataContract]
    [Serializable]
    public partial class AtividadesEconomicasEntity : BaseEntity, ISincronizavelFederalEntity
    {
        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdAtividadeEconomica;
            }
            set
            {
                IdAtividadeEconomica = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[AtividadesEconomicas]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdAtividadeEconomica { get; set; }




        /// <summary>
        /// Tamanho maximo 10 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(10)]
        public string CodigoCNAE { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(250)]
        public string DenominacaoCNAE { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string CodigoIntegracaoFederal { get; set; }

        #endregion


        #region Partial

        public AtividadesEconomicasEntity()
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
