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
    public partial class PessoasJuridicasAtividadesEconomicasEntity : BaseEntity
    {

        #region Auto

        

        
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaJuridicaAtividadeEconomica;
            }
            set
            {
                IdPessoaJuridicaAtividadeEconomica = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasJuridicasAtividadesEconomicas]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaJuridicaAtividadeEconomica { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoaJuridica { get; set; }



        [DataMember]
        [Required]
        public Guid IdAtividadeEconomica { get; set; }



        [DataMember]
        [Required]
        public bool Principal { get; set; }

        #endregion


        #region Partial

        public PessoasJuridicasAtividadesEconomicasEntity()
        {
            AtividadeEconomica = new AtividadesEconomicasEntity();
        }
        [DataMember]
        public AtividadesEconomicasEntity AtividadeEconomica { get; set; }

        #endregion
    }
}
