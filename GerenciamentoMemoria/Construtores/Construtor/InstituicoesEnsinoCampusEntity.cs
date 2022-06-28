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
	public partial class InstituicoesEnsinoCampusEntity : BaseEntity
	{

		#region Auto

		

	
		[DataMember]
		public override Guid Id
		{
			get
			{
				return IdInstituicaoEnsinoCampus;
			}
			set
			{
				IdInstituicaoEnsinoCampus = value;
			}
		}




		/// <summary>
		/// Campo chave para tabela [Cadastro].[InstituicoesEnsinoCampus]
		/// </summary>
		[DataMember]
		[Required]
		public Guid IdInstituicaoEnsinoCampus { get; set; }



		[DataMember]
		[Required]
		public Guid IdInstituicaoEnsino { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[Required]
		[StringLength(250)]
		public string Nome { get; set; }



		[DataMember]
		[Required]
		public bool Ativo { get; set; }




		/// <summary>
		/// Texto livre
		/// </summary>
		[DataMember]
		public string Observacao { get; set; }



		[DataMember]
		[Required]
		public Guid IdCidade { get; set; }



		[DataMember]
		public Guid? IdEstado { get; set; }



		[DataMember]
		public Guid? IdBairro { get; set; }




		/// <summary>
		/// Tamanho maximo 250 caracteres
		/// </summary>
		[DataMember]
		[StringLength(250)]
		public string Logradouro { get; set; }




		/// <summary>
		/// Tamanho maximo 10 caracteres
		/// </summary>
		[DataMember]
		[StringLength(10)]
		public string Numero { get; set; }




		/// <summary>
		/// Tamanho maximo 10 caracteres
		/// </summary>
		[DataMember]
		[StringLength(10)]
		public string CEP { get; set; }




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
		public string Email { get; set; }




		/// <summary>
		/// Texto livre
		/// </summary>
		[DataMember]
		public string Complemento { get; set; }




		/// <summary>
		/// Tamanho maximo 50 caracteres
		/// </summary>
		[DataMember]
		[StringLength(50)]
		public string CodigoIntegracaoFederal { get; set; }

		#endregion


		#region Partial

		public InstituicoesEnsinoCampusEntity()
		{
			Ativo = true;
			InstituicaoEnsino = new PessoasEntity();
			Coordenadores = new List<CoordenadoresEntity>();
			Cidade = new CidadesEntity();
		}

		[DataMember]
		public PessoasEntity InstituicaoEnsino { get; set; }

		[DataMember]
		public CidadesEntity Cidade { get; set; }

		[DataMember]
		public BairrosEntity Bairro { get; set; }

		[DataMember]
		public string NomeDescription { get; set; }

		[DataMember]
		public List<CoordenadoresEntity> Coordenadores { get; set; }

		[DataMember]
		public CoordenadoresEntity CoordenadorAtivo => Coordenadores.FirstOrDefault(x => x.Ativo == 1);

		public void Inativar()
		{
			Ativo = true;
		}

		#endregion
	}
}
