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
    public class CargosEntity : BaseEntity
    {
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdCargo;
            }
            set
            {
                IdCargo = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[Cargos]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdCargo { get; set; }




        /// <summary>
        /// Tamanho maximo 40 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(40)]
        public string Nome { get; set; }



        [DataMember]
        [Required]
        public int Ordem { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }
	}
}
