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
	[DataContract]
	[Serializable]
	public partial class PessoasJuridicasEntity : BaseEntity
	{

		#region Auto





		[DataMember]
		public override Guid Id
		{
			get { return IdPessoaJuridica; }
			set { IdPessoaJuridica = value; }
		}




		/// <summary>
		/// Campo chave para tabela [Cadastro].[PessoasJuridicas]
		/// </summary>
		[DataMember]
		[Required]
		public Guid IdPessoaJuridica { get; set; }



		[DataMember] [Required] public Guid IdPessoa { get; set; }




		/// <summary>
		/// Tamanho maximo 30 caracteres
		/// </summary>
		[DataMember]
		[StringLength(30)]
		public string InscricaoMunicipal { get; set; }




		/// <summary>
		/// Tamanho maximo 30 caracteres
		/// </summary>
		[DataMember]
		[StringLength(30)]
		public string NumeroRegistroJuntaCartorio { get; set; }



		[DataMember] [Required] public Guid IdNaturezaJuridica { get; set; }



		[DataMember] [Required] public Guid IdTipoCapital { get; set; }



		[DataMember] [Required] public Guid IdPorte { get; set; }



		[DataMember] [Required] public Guid IdTipoSede { get; set; }




		/// <summary>
		/// Texto livre
		/// </summary>
		[DataMember]
		public string ObjetoSocial { get; set; }



		[DataMember] [Required] public int FlagsBitwisePessoaJuridica { get; set; }



		[DataMember] public DateTime? DataFundacao { get; set; }



		[DataMember] public DateTime? DataJuntaComercial { get; set; }




		/// <summary>
		/// Tamanho maximo 200 caracteres
		/// </summary>
		[DataMember]
		[StringLength(200)]
		public string Cartorio { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string NumeroContrato { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string NumeroAlteracaoContratual { get; set; }



		[DataMember] public DateTime? DataCartorio { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string Folhas { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string Paginas { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string NumeroJuntaComercial { get; set; }




		/// <summary>
		/// Texto livre
		/// </summary>
		[DataMember]
		public string MotivoEnquadramento { get; set; }




		/// <summary>
		/// Tamanho maximo 20 caracteres
		/// </summary>
		[DataMember]
		[StringLength(20)]
		public string Sigla { get; set; }



		[DataMember] [Required] public bool EmpresaJunior { get; set; }



		[DataMember] [Required] public decimal CapitalSocial { get; set; }


		#endregion

		#region Partial

		public PessoasJuridicasEntity()
		{
			this.PessoaJuridicaLivros = new List<PessoasJuridicasLivrosEntity>();
			this.AtividadesEconomicas = new List<PessoasJuridicasAtividadesEconomicasEntity>();
			this.Responsaveis = new List<PessoasJuridicasResponsaveisEntity>();
			this.PessoasJuridicasFiliais = new List<PessoasJuridicasFiliaisEntity>();
			this.CapitalSocial = 0;

		}

		/// <summary>
		/// Define as atividades econômicas da pessoa jurídica
		/// </summary>


		[DataMember]
		public List<PessoasJuridicasAtividadesEconomicasEntity> AtividadesEconomicas { get; set; }

		[DataMember] public NaturezasJuridicasEntity NaturezaJuridica { get; set; }

		[DataMember] public PessoasEntity Pessoa { get; set; }

		[DataMember] public List<PessoasJuridicasLivrosEntity> PessoaJuridicaLivros { get; set; }

		[DataMember]
		public FlagsBitwisePessoaJuridica Atributos
		{
			get { return (FlagsBitwisePessoaJuridica)this.FlagsBitwisePessoaJuridica; }
			set { this.FlagsBitwisePessoaJuridica = value.ToInt32(); }
		}

		[DataMember] public List<PessoasJuridicasResponsaveisEntity> Responsaveis { get; set; }

		/// <summary>
		/// Relação das Empresas Filiais que esta "Pessoa Juridica" possui
		/// </summary>
		[DataMember]
		public List<PessoasJuridicasFiliaisEntity> PessoasJuridicasFiliais { get; set; }

		#endregion
	}
}
