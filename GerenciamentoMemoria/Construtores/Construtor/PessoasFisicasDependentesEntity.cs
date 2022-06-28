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
    public class PessoasFisicasDependentesEntity : BaseEntity
    {
		#region Auto

		[DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaFisicaDependente;
            }
            set
            {
                IdPessoaFisicaDependente = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasFisicasDependentes]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaFisicaDependente { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoaFisica { get; set; }



        [DataMember]
        [Required]
        public Guid IdDependente { get; set; }



        [DataMember]
        [Required]
        public Guid IdTipoDependente { get; set; }



        [DataMember]
        [Required]
        public DateTime DataInicio { get; set; }



        [DataMember]
        public DateTime? DataTermino { get; set; }

        #endregion

        #region Partial

        [DataMember]
        public string NomeDependente { get; set; }

        [DataMember]
        public string TipoDependente { get; set; }


        #endregion
    }
}
