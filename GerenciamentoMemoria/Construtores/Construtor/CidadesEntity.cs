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
    public class CidadesEntity : BaseEntity
    {

		#region Auto


		[DataMember]
        [Required]
        public Guid IdEstado { get; set; }




        /// <summary>
        /// Tamanho maximo 100 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdCidade;
            }
            set
            {
                IdCidade = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Corporativo].[Cidades]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdCidade { get; set; }



        [DataMember]
        public int? CodigoIBGE { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }



        [DataMember]
        public int? CodigoDistritoIbge { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeUsuarioChancela { get; set; }



        [DataMember]
        public DateTime? DataChancela { get; set; }



        [DataMember]
        public int? Populacao { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string JustificativaChancela { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string CodigoIntegracaoFederal { get; set; }


        #endregion


        #region Partial


        public CidadesEntity()
        {
            Ativo = true;
            Estado = new EstadosEntity()
            {
                IdEstado = Guid.Empty,
                Pais = new PaisesEntity() { IdPais = Guid.Empty }
            };
        }

        /// <summary>
        /// Estado da Cidade
        /// </summary>
        [DataMember]
        public EstadosEntity Estado { get; set; }

        public void Inativar()
        {
            Ativo = false;
        }

        #endregion
    }
}
