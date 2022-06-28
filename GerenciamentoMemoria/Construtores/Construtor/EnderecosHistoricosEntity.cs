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
	public partial class EnderecosHistoricosEntity : BaseEntity
	{

		#region Auto




		[DataMember]
		public override Guid Id
		{
			get { return IdEnderecoHistorico; }
			set { IdEnderecoHistorico = value; }
		}




		/// <summary>
		/// Campo chave para tabela [Cadastro].[EnderecosHistoricos]
		/// </summary>
		[DataMember]
		[Required]
		public Guid IdEnderecoHistorico { get; set; }



		[DataMember] [Required] public Guid IdEndereco { get; set; }



		[DataMember] [Required] public Guid IdPessoa { get; set; }



		[DataMember] [Required] public Guid IdCidade { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[Required]
		[StringLength(250)]
		public string Logradouro { get; set; }




		/// <summary>
		/// Tamanho maximo 10 caracteres
		/// </summary>
		[DataMember]
		[StringLength(10)]
		public string Numero { get; set; }



		[DataMember] public Guid? IdBairro { get; set; }




		/// <summary>
		/// Tamanho maximo 100 caracteres
		/// </summary>
		[DataMember]
		[StringLength(100)]
		public string Complemento { get; set; }




		/// <summary>
		/// Tamanho maximo 30 caracteres
		/// </summary>
		[DataMember]
		[StringLength(30)]
		public string CaixaPostal { get; set; }




		/// <summary>
		/// Tamanho maximo 10 caracteres
		/// </summary>
		[DataMember]
		[Required]
		[StringLength(10)]
		public string CEP { get; set; }



		[DataMember] [Required] public bool Correspondencia { get; set; }



		[DataMember] [Required] public bool Atualizado { get; set; }




		/// <summary>
		/// Texto livre
		/// </summary>
		[DataMember]
		public string Observacao { get; set; }



		[DataMember] public DateTime? DataAtualizacao { get; set; }



		[DataMember] [Required] public bool Preferencial { get; set; }



		[DataMember] [Required] public int Local { get; set; }



		[DataMember] [Required] public bool MalaDireta { get; set; }



		[DataMember] [Required] public bool Publico { get; set; }



		[DataMember] public Guid? IdLogradouroDNE { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string NomeUsuarioCriacao { get; set; }



		[DataMember] public DateTime? DataCriacao { get; set; }




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




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string Latitude { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string Longitude { get; set; }



		[DataMember] [Required] public Guid IdMotivoDevolucaoEndereco { get; set; }



		[DataMember] public int? CEPNumerico { get; set; }

		#endregion


		#region Partial

		public EnderecosHistoricosEntity()
		{
			Publico = true;
			MalaDireta = true;
			Atualizado = true;
			IdLogradouroDNE = null;
			Local = 1;
			this.Bairro = new BairrosEntity();
			this.Cidade = new CidadesEntity();
		}

		[DataMember] public BairrosEntity Bairro { get; set; }

		[DataMember] public CidadesEntity Cidade { get; set; }

		[DataMember] public string LogradouroFormatado { get; set; }

		[DataMember] public string CepFormatado { get; set; }

		[DataMember] public bool Exterior { get; set; }

		/// <summary>
		/// Concatena os campos, e monta o endereço completo.
		/// Este campo não existe no banco de dados, é preenchido no Business no método BuscarRegistros
		/// </summary>
		[DataMember]
		public string EnderecoCompleto { get; set; }


		public LocalEndereco LocalEndereco
		{
			get { return (LocalEndereco)this.Local; }
		}

		public string LocalEnderecoDescription
		{
			get { return LocalEndereco.GetDescription(); }
		}

		//Controle criado para evitar a duplicidade da criação de subregião na nova inscrição
		public bool IgnorarExecucaoRotinasCalcularRASubRegiao { get; set; }

		#endregion

	}
}
