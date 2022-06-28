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
	[DataContract]
    [Serializable]
    public partial class NaturezasJuridicasEntity : BaseEntity
    {
        #region Auto

        

       

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdNaturezaJuridica;
            }
            set
            {
                IdNaturezaJuridica = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[NaturezasJuridicas]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdNaturezaJuridica { get; set; }




        /// <summary>
        /// Tamanho maximo 100 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }




        /// <summary>
        /// Tamanho maximo 10 caracteres
        /// </summary>
        [DataMember]
        [StringLength(10)]
        public string CodigoCONCLA { get; set; }



        [DataMember]
        [Required]
        public int Configuracao { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string CodigoIntegracaoFederal { get; set; }

        #endregion

        #region Partial

        public NaturezasJuridicasEntity()
        {
            Ativo = true;
        }

        public bool IsencaoFinanceira
        {
            get
            {
                return ((NaturezaJuridicaConfiguracoes)Configuracao).Has(NaturezaJuridicaConfiguracoes.IsencaoFinanceira);
            }
            set
            {
                var config = (NaturezaJuridicaConfiguracoes)Configuracao;

                if (value)
                    config = config.Add(NaturezaJuridicaConfiguracoes.IsencaoFinanceira);

                if (!value)
                    config = config.Remove(NaturezaJuridicaConfiguracoes.IsencaoFinanceira);

                Configuracao = (int)config;
            }

        }

        public void Inativar()
        {
            Ativo = false;
        }

        #endregion
    }
}
