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
    public class PessoasJuridicasLivrosEntity : BaseEntity
    {

		#region Auto

		[DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaJuridicaLivros;
            }
            set
            {
                IdPessoaJuridicaLivros = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasJuridicasLivros]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaJuridicaLivros { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoaJuridica { get; set; }



        [DataMember]
        [Required]
        public Guid IdLivroTipo { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string NumeroLivro { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string AnoLivro { get; set; }

        #endregion


        #region Partial

        public PessoasJuridicasLivrosEntity()
        {
            LivroTipo = new LivrosTiposEntity();
            PessoaJuridica = new PessoasJuridicasEntity();
        }

        [DataMember]
        public PessoasJuridicasEntity PessoaJuridica { get; set; }

        [DataMember]
        public LivrosTiposEntity LivroTipo { get; set; }

        #endregion
    }
}
