using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    public static class Constants
    {

        public static TimeSpan LimiteExpirarCacheInMemory = TimeSpan.FromMinutes(1);

        public static readonly Guid IdPessoaConselho = new Guid("00000000-0000-0000-0000-000000000001");
        public static readonly Guid IdPessoaNaoInformada = Guid.Empty;
        public static readonly Guid CodSistema = new Guid("00000000-0000-0000-0000-000000000000");
        public static readonly Guid IdNaturezaJuridicaPadrao = new Guid("00000000-0000-0000-0000-000000001104");
        public static readonly Guid IdNaturezaJuridicaNaoInformada = new Guid("00000000-0000-0000-0000-000000009010");

        public static readonly Guid IdPortePadrao = new Guid("01FDA1B6-A10B-E111-A3B4-B8AC6FC43B89");
        public static readonly Guid IdTipoCapitalPadrao = new Guid("FAFCA1B6-A10B-E111-A3B4-B8AC6FC43B89");
        public static readonly Guid IdTipoSedePadrao = new Guid("06FDA1B6-A10B-E111-A3B4-B8AC6FC43B89");


        public static readonly Guid IdPaisBrasil = new Guid("00000000-0000-0000-0000-000000000036");

        public static readonly Guid IdSistemaSiscaf = Guid.Parse("00000000-0000-0000-0000-000000000011");

        public static readonly Guid IdSistemaServicosOnline = Guid.Parse("00000000-0000-0000-0000-000000000018");

        public static readonly Guid IdTipoBasicoEstadoCivil = Guid.Parse("00000000-0000-0000-0000-000000000001");
        public static readonly Guid IdTipoBasicoEscolaridade = Guid.Parse("00000000-0000-0000-0000-000000000002");
        public static readonly Guid IdTipoBasicoOrigem = Guid.Parse("00000000-0000-0000-0000-000000000011");
        public static readonly Guid IdTipoBasicoEtinia = Guid.Parse("00000000-0000-0000-0000-000000000006");
        public static readonly Guid IdTipoBasicoTipoSanguineo = Guid.Parse("00000000-0000-0000-0000-000000000007");
        public static readonly Guid IdTipoBasicoPrioridadeTramitacao = Guid.Parse("00000000-0000-0000-0000-000000000012");
        public static readonly Guid IdTipoBasicoTiposCapital = Guid.Parse("00000000-0000-0000-0000-000000000003");
        public static readonly Guid IdTipoBasicoTiposSede = Guid.Parse("00000000-0000-0000-0000-000000000005");
        public static readonly Guid IdTipoBasicoTiposDocumentos = Guid.Parse("00000000-0000-0000-0000-000000000008");


        public static readonly Guid IdEtiniaNaoInformada = Guid.Parse("00000000-0000-0000-0000-000000000600");
        public static readonly Guid IdTipoSanguineoNaoInformado = Guid.Parse("00000000-0000-0000-0000-000000000700");
        public static readonly Guid IdEstadoCivilNaoInformado = Guid.Parse("E4FCA1B6-A10B-E111-A3B4-B8AC6FC43B89");

        public static readonly Guid ID_BANCO_BRADESCO = Guid.Parse("00000000-0000-0000-0000-000000000019");
        public static readonly Guid ID_BANCO_BRASIL = Guid.Parse("00000000-0000-0000-0000-000000000043");


        public static readonly Guid ID_BANCO_CAIXA = Guid.Parse("00000000-0000-0000-0000-000000000112");

        public static readonly Guid IdConfiguracaoResponsabilidade = Guid.Parse("00000000-0000-0000-0000-000000000001");

        public static readonly Guid IdSituacaoResponsabilidadeNaoInformado = Guid.Parse("00000000-0000-0000-0000-000000000001");
        public static readonly Guid IdMacroRegiaoNaoInformada = Guid.Parse("00000000-0000-0000-0000-000000000000");

        public static string PermissaoAlterarNomeCpfcnpj = "AlterarNomeCPFCNPJ";

        public static string IgnorarValidacaoCPFCNPJ = "IgnorarValidacaoCPFCNPJ";

        public static readonly int TAKE_CHUNKS_VALUE_DEFAULT = 2000;

        //public static Core.Usuario InformacaoUsuarioSistema => new Core.Usuario
        //{
        //    IdUsuario = IdPessoaConselho,
        //    Nome = Resource.Cadastro.InformacaoUsuarioSistemaNome,
        //    UnidadeNome = Resource.Cadastro.InformacaoUsuarioSistemaNomeUnidade
        //};

        public static List<string> CPFCNPJGenericos =>
            new List<string>
            {
                "00000000000000",
                "11111111111111",
                "00000000000",
                "11111111111"
            };


        public static ConcurrentBag<Guid> IdsBancosArquivoRetorno =>
            new ConcurrentBag<Guid>
            {
                ID_BANCO_BRADESCO,
                ID_BANCO_BRASIL,
                ID_BANCO_CAIXA
            };

        public const string TipoVinculoProcessoInscricao = "ProcessoInscricao";

        //TipoNotificação
        public static readonly Guid ID_NOTIFICACAO_TIPO_PADRAO = Guid.Parse("00000000-0000-0000-0000-000000000000");
        public static readonly Guid ID_NOTIFICACAO_TIPO_SOLICITACAO_INSCRICAO = Guid.Parse("00000000-0000-0000-0000-000000000001");
        public static readonly Guid ID_NOTIFICACAO_TIPO_RETORNO_SOLICITACAO_INSCRICAO = Guid.Parse("00000000-0000-0000-0000-000000000002");
        public static readonly Guid ID_NOTIFICACAO_TIPO_SOLICITACAO_TRANSFORMACAO = Guid.Parse("00000000-0000-0000-0000-000000000003");
        public static readonly Guid ID_NOTIFICACAO_TIPO_RETORNO_SOLICITACAO_TRANSFORMACAO = Guid.Parse("00000000-0000-0000-0000-000000000004");
        public static readonly Guid ID_NOTIFICACAO_TIPO_SOLICITACAO_ESPECIALIDADE = Guid.Parse("00000000-0000-0000-0000-000000000005");
        public static readonly Guid ID_NOTIFICACAO_TIPO_RETORNO_SOLICITACAO_ESPECIALIDADE = Guid.Parse("00000000-0000-0000-0000-000000000006");
        public static readonly Guid ID_NOTIFICACAO_FISCALIZACAO = Guid.Parse("00000000-0000-0000-0000-000000000007");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_PERITOS = Guid.Parse("00000000-0000-0000-0000-000000000011");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_MEDIADORES_ARBITROS = Guid.Parse("00000000-0000-0000-0000-000000000012");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_CARTEIRA_IDENTIDADE_PROFISSIONAL = Guid.Parse("00000000-0000-0000-0000-000000000013");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_CERTIDAO = Guid.Parse("00000000-0000-0000-0000-000000000014");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_RCA = Guid.Parse("00000000-0000-0000-0000-000000000015");
        public static readonly Guid ID_NOTIFICACAO_DE_DEBITOS_PARA_FISCALIZACAO = Guid.Parse("00000000-0000-0000-0000-000000000017");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_CARTEIRA_IDENTIDADE_PROFISSIONAL_DIGITAL = Guid.Parse("00000000-0000-0000-0000-000000000018");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_INCLUSAO_RESPONSAVEL_TECNICO = Guid.Parse("00000000-0000-0000-0000-000000000019");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_BAIXA_RESPONSAVEL_TECNICO = Guid.Parse("00000000-0000-0000-0000-000000000020");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_SEGUNDA_CARTEIRA_IDENTIDADE_PROFISSIONAL = Guid.Parse("00000000-0000-0000-0000-000000000021");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_PRE_CADASTRO = Guid.Parse("00000000-0000-0000-0000-000000000022");
        public static readonly Guid ID_NOTIFICACAO_REQUERIMENTO_GENERICO = Guid.Parse("00000000-0000-0000-0000-000000000023");

        public static readonly Guid NivelCursoNaoInformado = Guid.Parse("00000000-0000-0000-0000-000000000001");

        public static readonly Guid ReligiaoNaoInformado = Guid.Parse("00000000-0000-0000-0000-000000000000");


        public const string NaoInformado = "NaoInformado";
        public const string Visa = "Visa";
        public const string Mastercard = "Mastercard";
        public const string AmericanExpress = "AmericanExpress";
        public const string Diners = "Diners";
        public const string Elo = "Elo";
        public const string Aura = "Aura";
        public const string JCB = "JCB";
        public const string Hipercard = "Hipercard";

        public const int Maioridade = 18;

        public static readonly string ENVIO_DOCUMENTOS_POR_EMAIL_NOME_RAZAO_SOCIAL = "@[NomeRazaoSocial]";
        public static readonly string ENVIO_DOCUMENTOS_POR_EMAIL_REGISTRO_INSCRICAO = "@[RegistroInscricao]";
        public static readonly string ENVIO_DOCUMENTOS_POR_EMAIL_CATEGORIA = "@[Categoria]";
        public static readonly string ENVIO_DOCUMENTOS_POR_EMAIL_SITUACAO = "@[Situacao]";
        public static readonly string ENVIO_DOCUMENTOS_POR_EMAIL_TIPO_INSCRICAO = "@[TipoInscricao]";
        public static readonly string ENVIO_DOCUMENTOS_POR_EMAIL_TIPO_DOCUMENTO = "@[TipoDocumento]";
        public static readonly string ENVIO_DOCUMENTOS_POR_EMAIL_FUNCIONALIDADE_DOCUMENTO = "@[FuncionalidadeDocumento]";
        public static readonly string ENVIO_DOCUMENTOS_POR_EMAIL_DATA_DOCUMENTO = "@[DataDocumento]";
        public static readonly string ENVIO_DOCUMENTOS_POR_EMAIL_SITUACAO_DOCUMENTO = "@[SituacaoDocumento]";

        public static readonly Guid ArquivoAnexoIDEntidadeAssinaturaPresidente = Guid.Parse("00000000-0000-0000-0000-000000000001");
        public static readonly Guid ArquivoAnexoIDEntidadeAssinaturaTesoureiro = Guid.Parse("00000000-0000-0000-0000-000000000002");
        public static readonly Guid ArquivoAnexoIDEntidadeAssinaturaSecretario = Guid.Parse("00000000-0000-0000-0000-000000000003");

        public static Dictionary<string, string> EnvioDocumentosPorEmailParametros
        {
            get
            {
                var dicionario = new Dictionary<string, string>();

                dicionario.Add(ENVIO_DOCUMENTOS_POR_EMAIL_NOME_RAZAO_SOCIAL, "Informa o nome/razão social da pessoa");
                dicionario.Add(ENVIO_DOCUMENTOS_POR_EMAIL_REGISTRO_INSCRICAO, "Informa o registro de inscrição da pessoa");
                dicionario.Add(ENVIO_DOCUMENTOS_POR_EMAIL_CATEGORIA, "Informa a categoria da pessoa");
                dicionario.Add(ENVIO_DOCUMENTOS_POR_EMAIL_SITUACAO, "Informa a situação da pessoa");
                dicionario.Add(ENVIO_DOCUMENTOS_POR_EMAIL_TIPO_INSCRICAO, "Informa o tipo de inscrição da pessoa");
                dicionario.Add(ENVIO_DOCUMENTOS_POR_EMAIL_TIPO_DOCUMENTO, "Informa o tipo de documento");
                dicionario.Add(ENVIO_DOCUMENTOS_POR_EMAIL_FUNCIONALIDADE_DOCUMENTO, "Informa a funcionalidade do documento");
                dicionario.Add(ENVIO_DOCUMENTOS_POR_EMAIL_DATA_DOCUMENTO, "Informa a data do documento");
                dicionario.Add(ENVIO_DOCUMENTOS_POR_EMAIL_SITUACAO_DOCUMENTO, "Informa a situação do documento");

                return dicionario;
            }
        }

        public const string ParametroAdicional_CNPJOutroConselho_Key = "ParametroAdicional_CNPJOutroConselho_Key";

        //1GB
        //Propriedade regula a quebra de arquivos por aproximadamente 1GB para downloads
        public static readonly int TamanhoEmBytesQuebraArquivoAutomatica = 1000000000;

        public static Guid IdRedeSocialInstagram = new Guid("00000000-0000-0000-0000-000000000001");
    }
}
