using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;
using Construtores.Entity;

namespace Construtores.Construtor
{
	[DataContract]
	[Serializable]
	public partial class UnidadesEntity : BaseEntity
	{

		#region Auto

		

		

		[DataMember]
		public override Guid Id
		{
			get
			{
				return IdUnidade;
			}
			set
			{
				IdUnidade = value;
			}
		}




		/// <summary>
		/// Campo chave para tabela [Cadastro].[Unidades]
		/// </summary>
		[DataMember]
		[Required]
		public Guid IdUnidade { get; set; }




		/// <summary>
		/// Tamanho maximo 60 caracteres
		/// </summary>
		[DataMember]
		[Required]
		[StringLength(60)]
		public string Nome { get; set; }




		/// <summary>
		/// Tamanho maximo 12 caracteres
		/// </summary>
		[DataMember]
		[Required]
		[StringLength(12)]
		public string Codigo { get; set; }




		/// <summary>
		/// Tamanho maximo 15 caracteres
		/// </summary>
		[DataMember]
		[StringLength(15)]
		public string Sigla { get; set; }




		/// <summary>
		/// Tamanho maximo 20 caracteres
		/// </summary>
		[DataMember]
		[StringLength(20)]
		public string Telefone { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string Contato { get; set; }



		[DataMember]
		public Guid? IdBairro { get; set; }



		[DataMember]
		[Required]
		public Guid IdCidade { get; set; }




		/// <summary>
		/// Tamanho maximo 10 caracteres
		/// </summary>
		[DataMember]
		[StringLength(10)]
		public string Numero { get; set; }




		/// <summary>
		/// Tamanho maximo 100 caracteres
		/// </summary>
		[DataMember]
		[StringLength(100)]
		public string Complemento { get; set; }




		/// <summary>
		/// Tamanho maximo 10 caracteres
		/// </summary>
		[DataMember]
		[StringLength(10)]
		public string CEP { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string Logradouro { get; set; }



		[DataMember]
		[Required]
		public bool Ativo { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string Email { get; set; }



		[DataMember]
		[Required]
		public bool EnviarDocumentosPorEmail { get; set; }



		[DataMember]
		public Guid? IdConfiguracaoSMTP { get; set; }




		/// <summary>
		/// Tamanho maximo 300 caracteres
		/// </summary>
		[DataMember]
		[StringLength(300)]
		public string EmailAssunto { get; set; }




		/// <summary>
		/// Texto livre
		/// </summary>
		[DataMember]
		public string EmailCorpo { get; set; }

		#endregion


		#region Partial

		public UnidadesEntity()
		{
			Cidade = new CidadesEntity();
			Bairro = new BairrosEntity();
			PessoaPadrao = new PessoasEntity();
			Responsaveis = new List<ResponsaveisUnidadesEntity>();
			Pessoas = new List<PessoasUnidadesEntity>();
			Ativo = true;
		}

		[DataMember]
		public CidadesEntity Cidade { get; set; }

		[DataMember]
		public BairrosEntity Bairro { get; set; }

		[DataMember]
		public PessoasEntity PessoaPadrao { get; set; }

		[DataMember]
		public List<PessoasUnidadesEntity> Pessoas { get; set; }

		[DataMember]
		public List<ResponsaveisUnidadesEntity> Responsaveis { get; set; }


		[DataMember]
		public int? IdAntigo { get; set; }

		[DataMember]
		public string NomeSiglaUserControl { get; set; }

		[DataMember]
		public bool ShowResponsaveis { get; set; }

		#endregion
	}
}
