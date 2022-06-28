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
	public partial class PessoasFisicasEntity : BaseEntity
	{

		#region  Auto

		


		

		[DataMember]
		public override Guid Id
		{
			get
			{
				return IdPessoaFisica;
			}
			set
			{
				IdPessoaFisica = value;
			}
		}




		/// <summary>
		/// Campo chave para tabela [Cadastro].[PessoasFisicas]
		/// </summary>
		[DataMember]
		[Required]
		public Guid IdPessoaFisica { get; set; }



		[DataMember]
		[Required]
		public Guid IdPessoa { get; set; }



		[DataMember]
		[Required]
		public Guid IdNacionalidade { get; set; }



		[DataMember]
		[Required]
		public Guid IdNaturalidade { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string NomePai { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string NomeMae { get; set; }




		/// <summary>
		/// Tamanho maximo 30 caracteres
		/// </summary>
		[DataMember]
		[StringLength(30)]
		public string RGEmissor { get; set; }



		[DataMember]
		[Required]
		public Guid IdEscolaridade { get; set; }



		[DataMember]
		[Required]
		public Guid IdEstadoCivil { get; set; }



		[DataMember]
		public bool? GeneroMasculino { get; set; }




		/// <summary>
		/// Tamanho maximo 30 caracteres
		/// </summary>
		[DataMember]
		[StringLength(30)]
		public string PISPASEP { get; set; }



		[DataMember]
		public Guid? IdCargo { get; set; }



		[DataMember]
		[Required]
		public int FlagsBitwisePessoaFisica { get; set; }



		[DataMember]
		public Guid? IdEtnia { get; set; }



		[DataMember]
		public Guid? IdTipoSanguineo { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string RNE { get; set; }



		[DataMember]
		public DateTime? RNEDataValidade { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string TituloEleitorNumero { get; set; }




		/// <summary>
		/// Tamanho maximo 10 caracteres
		/// </summary>
		[DataMember]
		[StringLength(10)]
		public string TituloEleitorZona { get; set; }




		/// <summary>
		/// Tamanho maximo 10 caracteres
		/// </summary>
		[DataMember]
		[StringLength(10)]
		public string TituloEleitorSecao { get; set; }



		[DataMember]
		public DateTime? TituloEleitorDataEmissao { get; set; }



		[DataMember]
		public Guid? TituloEleitorIdCidade { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string CDINumero { get; set; }




		/// <summary>
		/// Tamanho maximo 5 caracteres
		/// </summary>
		[DataMember]
		[StringLength(5)]
		public string CDISerie { get; set; }




		/// <summary>
		/// Tamanho maximo 10 caracteres
		/// </summary>
		[DataMember]
		[StringLength(10)]
		public string CDICSM { get; set; }



		[DataMember]
		public DateTime? CDIEmissao { get; set; }



		[DataMember]
		public DateTime? DataNascimento { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string NomeConjuge { get; set; }



		[DataMember]
		public Guid? RGIdEstado { get; set; }



		[DataMember]
		public DateTime? RGDataEmissao { get; set; }



		[DataMember]
		public bool? DoadorOrgaos { get; set; }



		[DataMember]
		[Required]
		public bool Estrangeiro { get; set; }



		[DataMember]
		[Required]
		public bool NaoPossuiMaeRG { get; set; }



		[DataMember]
		[Required]
		public bool NaoPossuiPaiRG { get; set; }



		[DataMember]
		public Guid? IdReligiao { get; set; }



		[DataMember]
		[Required]
		public Guid IdTipoDeficiencia { get; set; }



		[DataMember]
		[Required]
		public Guid IdEmissorReservista { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string Passaporte { get; set; }



		[DataMember]
		public Guid? IdOrientacaoSexual { get; set; }



		[DataMember]
		[Required]
		public bool FotoPublica { get; set; }



		[DataMember]
		public Guid? IdAposentadoria { get; set; }



		[DataMember]
		public Guid? IdFaixaRenda { get; set; }



		[DataMember]
		public Guid? IdIdentidadeGenero { get; set; }



		[DataMember]
		public Guid? IdGenero { get; set; }



		[DataMember]
		public Guid? IdTecnologiaAssistiva { get; set; }



		[DataMember]
		public Guid? IdSituacaoProfissional { get; set; }


		#endregion

		#region Partial

		public PessoasFisicasEntity()
		{
			IdEscolaridade = Guid.Parse("EAFCA1B6-A10B-E111-A3B4-B8AC6FC43B89");
			IdEstadoCivil = Guid.Parse("E4FCA1B6-A10B-E111-A3B4-B8AC6FC43B89");
			GeneroMasculino = true;
			RGEmissor = "SSP";
			Dependentes = new List<PessoasFisicasDependentesEntity>();
			FotoPublica = true;
			Naturalidade = new CidadesEntity();
			Nacionalidade = new PaisesEntity();
		}

		[DataMember]
		public CargosEntity Cargo { get; set; }

		[DataMember]
		public PessoasEntity Pessoa { get; set; }

		[DataMember]
		public CidadesEntity Naturalidade { get; set; }

		[DataMember]
		public PaisesEntity Nacionalidade { get; set; }

		[DataMember]
		public EstadosEntity SiglaUF { get; set; }

		[DataMember]
		public EstadosEntity EstadoRGEmissor { get; set; }

		[DataMember]
		public TiposBasicosItensEntity EstadoCivil { get; set; }

		[DataMember]
		public TiposBasicosItensEntity TipoSanguineo { get; set; }

		[DataMember]
		public TiposBasicosItensEntity Etnia { get; set; }

		[DataMember]
		public CidadesEntity TituloEleitorCidade { get; set; }

		[DataMember]
		public OrientacoesSexuaisEntity OrientacaoSexual { get; set; }

		[DataMember]
		public IdentidadesGeneroEntity IdentidadesGenero { get; set; }

		[DataMember]
		public ReligioesEntity Religiao { get; set; }

		[DataMember]
		public TiposDeficienciasEntity TipoDeficiencia { get; set; }

		[DataMember]
		public FlagsBitwisePessoaFisica Atributos
		{
			get
			{
				return (FlagsBitwisePessoaFisica)FlagsBitwisePessoaFisica;
			}
			set
			{
				FlagsBitwisePessoaFisica = value.ToInt32();
			}
		}

		/// <summary>
		/// Define os dependentes da pessoa física
		/// </summary>
		[DataMember]
		public List<PessoasFisicasDependentesEntity> Dependentes { get; set; }

		[DataMember]
		public BooleanOption ToggleDoador
		{
			get
			{
				switch (DoadorOrgaos)
				{
					case true:
						return BooleanOption.True;
					case false:
						return BooleanOption.False;
					default:
						return BooleanOption.All;
				}
			}
			set
			{
				switch (value)
				{
					case BooleanOption.True:
						DoadorOrgaos = true;
						break;

					case BooleanOption.False:
						DoadorOrgaos = false;
						break;

					default:
						DoadorOrgaos = null;
						break;
				}
			}
		}

		[DataMember]
		public BooleanOption ToggleGeneroMasculino
		{
			get
			{
				switch (GeneroMasculino)
				{
					case true:
						return BooleanOption.True;
					case false:
						return BooleanOption.False;
					default:
						return BooleanOption.All;
				}
			}
			set
			{
				switch (value)
				{
					case BooleanOption.True:
						GeneroMasculino = true;
						break;

					case BooleanOption.False:
						GeneroMasculino = false;
						break;

					default:
						GeneroMasculino = null;
						break;
				}
			}
		}

		#endregion
	}
}
