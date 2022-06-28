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
    public partial class CoordenadoresEntity : BaseEntity
    {

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdCoordenador;
            }
            set
            {
                IdCoordenador = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[Coordenadores]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdCoordenador { get; set; }



        [DataMember]
        [Required]
        public Guid IdInstituicaoEnsinoCampus { get; set; }



        [DataMember]
        [Required]
        public Guid IdRegistro { get; set; }



        [DataMember]
        [Required]
        public DateTime DataInicio { get; set; }



        [DataMember]
        public DateTime? DataFim { get; set; }



        [DataMember]
        [Required]
        public int Ativo { get; set; }
    }
}
