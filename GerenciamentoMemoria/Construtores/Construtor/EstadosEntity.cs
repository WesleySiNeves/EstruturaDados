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
    public class EstadosEntity : BaseEntity
    {

		#region Auto
		[DataMember]
        public override Guid Id
        {
            get
            {
                return IdEstado;
            }
            set
            {
                IdEstado = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Corporativo].[Estados]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdEstado { get; set; }



        [DataMember]
        [Required]
        public Guid IdPais { get; set; }




        /// <summary>
        /// Tamanho maximo 100 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }




        /// <summary>
        /// Tamanho maximo 2 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2)]
        public string SiglaUF { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }



        [DataMember]
        public int? CodigoIBGE { get; set; }


        #endregion


        #region Partial


        public EstadosEntity()
        {
            Pais = new PaisesEntity();
        }
        [DataMember]
        public PaisesEntity Pais { get; set; }

        #endregion
    }
}
