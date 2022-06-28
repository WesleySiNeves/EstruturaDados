using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;
using Construtores.Entity;
using Construtores.Util;

namespace Construtores.Construtor
{
    public class PessoasJuridicasResponsaveisEntity : BaseEntity
    {

	    #region Auto

	    

	   
		[DataMember]
		public override Guid Id
		{
			get
			{
				return IdPessoaJuridicaResponsavel;
			}
			set
			{
				IdPessoaJuridicaResponsavel = value;
			}
		}




		/// <summary>
		/// Campo chave para tabela [Cadastro].[PessoasJuridicasResponsaveis]
		/// </summary>
		[DataMember]
		[Required]
		public Guid IdPessoaJuridicaResponsavel { get; set; }



		[DataMember]
		[Required]
		public Guid IdPessoaJuridica { get; set; }



		[DataMember]
		[Required]
		public Guid IdPessoa { get; set; }



		[DataMember]
		[Required]
		public DateTime DataInicio { get; set; }



		[DataMember]
		public DateTime? DataFim { get; set; }



		[DataMember]
		[Required]
		public Guid IdCargo { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string Tratamento { get; set; }



		[DataMember]
		[Required]
		public Guid IdResponsabilidadeTipo { get; set; }



		[DataMember]
		[Required]
		public Guid IdResponsabilidadeSetor { get; set; }



		[DataMember]
		public decimal? Participacao { get; set; }




		/// <summary>
		/// Texto livre
		/// </summary>
		[DataMember]
		public string Observacao { get; set; }



		[DataMember]
		public DateTime? DataAtualizacao { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string NomeUsuarioCriacao { get; set; }



		[DataMember]
		public DateTime? DataCriacao { get; set; }




		/// <summary>
		/// Tamanho maximo 60 caracteres
		/// </summary>
		[DataMember]
		[StringLength(60)]
		public string NomeUnidadeCriacao { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string NomeUsuarioAtualizacao { get; set; }




		/// <summary>
		/// Tamanho maximo 60 caracteres
		/// </summary>
		[DataMember]
		[StringLength(60)]
		public string NomeUnidadeAtualizacao { get; set; }



		[DataMember]
		[Required]
		public Guid IdSituacaoResponsabilidade { get; set; }

		#endregion


		#region Partial

		public PessoasJuridicasResponsaveisEntity()
		{
			Cargo = new CargosEntity();
			Tipo = new ResponsabilidadesTiposEntity();
			Pessoa = new PessoasEntity();
			PessoaJuridica = new PessoasJuridicasEntity();
			IdSituacaoResponsabilidade = Constants.IdSituacaoResponsabilidadeNaoInformado;
		}
		[DataMember]
		public PessoasEntity Pessoa { get; set; }

		[DataMember]
		public PessoasJuridicasEntity PessoaJuridica { get; set; }

		[DataMember]
		public CargosEntity Cargo { get; set; }

		[DataMember]
		public ResponsabilidadesTiposEntity Tipo { get; set; }

		public string NomeRazaoSocialResponsavel { get; set; }

		public string RegistroResponsavel { get; set; }

		public string RegistroEmpresa { get; set; }

		#endregion
	}
}
