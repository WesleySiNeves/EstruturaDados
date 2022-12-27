using Construtores.Base;
using Construtores.Construtor;
using Construtores.Util;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Construtores.Entity
{
    public class PessoasEntityComplexo : BaseEntity
    {
       
        public PessoasEntityComplexo()
        {

          
            Especializacao = PessoaEspecializacao.Pessoa;
            TiposEntidades = new List<PessoasTiposEntidadesEntity>();
            AreasAtuacoes = new List<PessoasAreasAtuacoesEntity>();
            SetoresAtuacoes = new List<PessoasSetoresAtuacoesEntity>();
            Enderecos = new List<EnderecosEntity>();
            Emails = new List<EmailsEntity>();
            //_Emails = null;
            Telefones = new List<TelefonesEntity>();
            Imagens = new List<PessoasImagensEntity>();
            PessoasJuridicasResponsaveisEntity = new List<PessoasJuridicasResponsaveisEntity>();
            Ativo = true;
            Dependentes = new List<PessoasFisicasDependentesEntity>();
            PreferenciaCorrespondencia = PreferenciaTipoCorrespondencia;
            ChavesPix = new List<ChavesPixEntity>();
            Socios = new List<SociosEntity>();
            RedesSociais = new List<RedesSociaisEntity>();

        }


        public void teste()
        {
            var pe = new PessoasEntityComplexo();

            pe.PessoaFisica.NomeConjuge
        }



        public const int PreferenciaTipoCorrespondencia = (int)Util.PreferenciaCorrespondencia.ReceberPorCorreio;



        #region Auto

        /// <summary>
        /// Campo chave para tabela [Cadastro].[Pessoas]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(250)]
        public string NomeRazaoSocial { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeSocialFantasia { get; set; }



        [DataMember][Required] public bool TipoPessoaFisica { get; set; }




        /// <summary>
        /// Tamanho maximo 20 caracteres
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string CPFCNPJ { get; set; }




        /// <summary>
        /// Tamanho maximo 30 caracteres
        /// </summary>
        [DataMember]
        [StringLength(30)]
        public string RGIE { get; set; }




        /// <summary>
        /// Texto livre
        /// </summary>
        [DataMember]
        public string Observacao { get; set; }



        [DataMember] public DateTime? DataCriacao { get; set; }



        [DataMember] public DateTime? DataAtualizacao { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string EnderecoSite { get; set; }



        [DataMember][Required] public int FlagsBitwisePessoa { get; set; }



        [DataMember][Required] public bool VisivelSomenteSiscaf { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeUsuarioChancela { get; set; }



        [DataMember] public DateTime? DataChancela { get; set; }



        [DataMember][Required] public bool Estrangeiro { get; set; }



        [DataMember][Required] public bool Ativo { get; set; }



        [DataMember][Required] public int EspecializacaoValor { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeUsuarioCriacao { get; set; }




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



        [DataMember] public bool? EnderecoSitePublico { get; set; }



        [DataMember][Required] public int PreferenciaCorrespondencia { get; set; }




        /// <summary>
        /// Tamanho maximo 30 caracteres
        /// </summary>
        [DataMember]
        [StringLength(30)]
        public string Codigo { get; set; }




        /// <summary>
        /// Tamanho maximo 200 caracteres
        /// </summary>
        [DataMember]
        [StringLength(200)]
        public string NomeRazaoSocialSemPreposicao { get; set; }




        /// <summary>
        /// Tamanho maximo 20 caracteres
        /// </summary>
        [DataMember]
        [StringLength(20)]
        public string CPFCNPJSomenteNumeros { get; set; }




        /// <summary>
        /// Tamanho maximo 1000 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1000)]
        public string TermoConsulta { get; set; }


        #endregion

        #region Partial
        public Guid IdRegistro { get; set; }

        /// <summary>
        /// FlagsBitwise Especializações da Pessoa
        /// </summary>
        //[DataMember]
        public PessoaEspecializacao Especializacao
        {
            get
            {
                return (PessoaEspecializacao)EspecializacaoValor;
            }
            set
            {
                EspecializacaoValor = (int)value;
            }
        }


        public string TipoPessoaExtenso
        {
            get
            {
                var result = "";

                if (Especializacao.HasFlag(PessoaEspecializacao.PessoaFisica))
                {
                    result = "Pessoa física";

                    if (Especializacao.HasFlag(PessoaEspecializacao.ProfissionalRegistrado))
                        result = "Profissional";
                }

                if (Especializacao.HasFlag(PessoaEspecializacao.PessoaJuridica))
                {
                    result = "Pessoa jurídica";

                    if (Especializacao.HasFlag(PessoaEspecializacao.EmpresaRegistrada))
                        result = "Empresa";
                }

                return result;
            }
        }

        //[DataMember]

        //public PessoasFisicasEntity PessoaFisica { get; set; }


        //[DataMember]
        //public PessoasJuridicasEntity PessoaJuridica { get; set; }

        //[DataMember]
        //public InstituicoesEnsinoEntity InstituicaoEnsino { get; set; }



        #region Singleton 

        private  PessoasFisicasEntity _PessoaFisica;
        /// <summary>
        /// Define os dados de pessoa fisica
        /// </summary>
        [DataMember]
        public PessoasFisicasEntity PessoaFisica
        {

            get
            {

                if (_PessoaFisica == null)
                {
                    _PessoaFisica = new PessoasFisicasEntity();
                }

                return _PessoaFisica;
            }
            set
            {
                _PessoaFisica = value;

            }

        }


        public PessoasJuridicasEntity _PessoaJuridica;
        /// <summary>
        /// Define os dados de pessoa fisica
        /// </summary>
        [DataMember]
        public PessoasJuridicasEntity PessoaJuridica
        {

            get
            {

                if (_PessoaJuridica == null)
                {
                    _PessoaJuridica = new PessoasJuridicasEntity();
                }

                return _PessoaJuridica;
            }
            set
            {
                _PessoaJuridica = value;

            }

        }

        public InstituicoesEnsinoEntity _InstituicoesEnsino;
        /// <summary>
        /// Define os dados de pessoa fisica
        /// </summary>
        [DataMember]
        public InstituicoesEnsinoEntity InstituicaoEnsino
        {

            get
            {

                if (_InstituicoesEnsino == null)
                {
                    _InstituicoesEnsino = new InstituicoesEnsinoEntity();
                }

                return _InstituicoesEnsino;
            }
            set
            {
                _InstituicoesEnsino = value;

            }

        }

        //#endregion


        /// <summary>
        /// Define os endereços da pessoa
        /// </summary>
        [DataMember]
        public List<EnderecosEntity> Enderecos { get; set; }


        [DataMember]
        public List<EmailsEntity> Emails { get; set; }
        //private List<EmailsEntity> _Emails = null;

        ///// <summary>
        ///// Define os e-mails da pessoa
        ///// </summary>
        //[DataMember]
        //public List<EmailsEntity> Emails
        //{

        //    get
        //    {

        //        if (_Emails == null)
        //        {
        //            _Emails = new List<EmailsEntity>();
        //        }

        //        return _Emails;
        //    }
        //    set
        //    {

        //        _Emails = value;

        //    }
        //}

        /// <summary>
        /// Define os telefones da pessoa
        /// </summary>
        [DataMember]
        public List<TelefonesEntity> Telefones { get; set; }

        /// <summary>
        /// Define os grupos de perfil da pessoa
        /// </summary>
        [DataMember]
        public List<PessoasGruposPessoasEntity> Grupos { get; set; }

        /// <summary>
        /// Define os dados bancários da pessoa
        /// </summary>
        [DataMember]
        public List<DadosBancariosEntity> DadosBancarios { get; set; }

        /// <summary>
        /// Carrega as imagens da pessoa
        /// </summary>
        [DataMember]
        public List<PessoasImagensEntity> Imagens { get; set; }

        /// <summary>
        /// Unidade da Pessoa
        /// </summary>
        [DataMember]
        public PessoasUnidadesEntity PessoaUnidade { get; set; }

        /// <summary>
        /// Atributos da pessoa (bitwise)
        /// </summary>
        //[DataMember]
        public FlagsBitwisePessoa Atributos
        {
            get
            {
                return (FlagsBitwisePessoa)FlagsBitwisePessoa;
            }
            set
            {
                FlagsBitwisePessoa = value.ToInt32();
            }
        }

        /// <summary>
        /// Tipos de Entidades da Pessoa
        /// </summary>
        [DataMember]
        public List<PessoasTiposEntidadesEntity> TiposEntidades { get; set; }

        /// <summary>
        /// Áreas de Atuações da Pessoa
        /// </summary>
        [DataMember]
        public List<PessoasAreasAtuacoesEntity> AreasAtuacoes { get; set; }


        /// <summary>
        /// Setores de Atuações da Pessoa
        /// </summary>
        [DataMember]
        public List<PessoasSetoresAtuacoesEntity> SetoresAtuacoes { get; set; }



        /// <summary>
        /// Relação das Pessoas Juridicas que esta "Pessoa" possui responsabilidade
        /// </summary>
        [DataMember]
        public List<PessoasJuridicasResponsaveisEntity> PessoasJuridicasResponsaveisEntity { get; set; }


        /// <summary>
        ///Endereços da pessoa
        /// </summary>
        [DataMember]
        public string EnderecosRelatorio { get; set; }

        //No wizard, este campo é usado para informar se haverá criação de débitos, ao cadastrar a pessoa
        [DataMember]
        public Guid? IdConfiguracaoGeracaoDebito { get; set; }

        /// <summary>
        /// Utilizado no UserControl de Responsáveis para permitir buscas com acento.. o ASPCombobox é accent sensitive, problema similar ao user control de Plano de contas
        /// </summary>
        [DataMember]
        public string NomeRazaoSocialUserControl { get; set; }

        /// <summary>
        /// Utilizado para cadastrar email no cadastro de pessoas rápidas
        /// </summary>
        [DataMember]
        public string EmailCadastrarNovaPessoa { get; set; }


        public string PrimeiroNome
            => NomeRazaoSocial?.Split(' ')[0];

        public string UltimoSobreNome
            => NomeRazaoSocial != null && NomeRazaoSocial.Contains(" ")
                ? NomeRazaoSocial?.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).LastOrDefault()
                : string.Empty;

        public string NomeExibicaoReduzido
            => $"{PrimeiroNome} {UltimoSobreNome}".Trim();

        public string CPFCNPJNomeRazaoSocial
            => $"{CPFCNPJ} - {NomeRazaoSocial}".Trim();

        /// <summary>
        /// Lista de Dependentes associado à pessoa física
        /// </summary>
        [DataMember]
        public List<PessoasFisicasDependentesEntity> Dependentes { get; set; }

        [DataMember]
        public string LabelEmpresasSingularServicosOnline { get; set; }

        [DataMember]
        public string NomeSubregiao { get; set; }

        /// <summary>
        /// Listas de Chaves Pix da Pessoa
        /// </summary>
        [DataMember]
        public List<ChavesPixEntity> ChavesPix { get; set; }

        /// <summary>
        /// Listas de Chaves Pix da Pessoa
        /// </summary>
        [DataMember]
        public List<SociosEntity> Socios { get; set; }

        /// <summary>
        /// Define as redes sociais da pessoa
        /// </summary>
        [DataMember]
        public List<RedesSociaisEntity> RedesSociais { get; set; }

        [DataMember]
        public PessoasInformacoesComplementaresEntity InformacoesComplementares { get; set; }


        #endregion
    }
}
