using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;
using Construtores.Construtor.Interfaces;

namespace Construtores.Construtor
{
    //[DataContract]
    //[Serializable]
    //public class ArquivosAnexosEntity : BaseEntity, IMonitoravelEntity
    //{
    //    public ArquivosAnexosEntity()
    //    {
    //        Grupo = new ArquivosAnexosGruposEntity();
    //        Assinaturas = new List<ArquivosAnexosAssinaturasEntity>();
    //        VerificarConfiguracaoStorageExterno = true;
    //        Selecionado = false;
    //        DocumentoCancelado = false;
    //    }

    //    [DataMember]
    //    public override Guid Id
    //    {
    //        get => IdArquivoAnexo;
    //        set => IdArquivoAnexo = value;
    //    }

    //    [DataMember]
    //    public Guid IdArquivoAnexo { get; set; }

    //    [DataMember]
    //    public Guid IdEntidade { get; set; }

    //    [DataMember]
    //    public string Entidade { get; set; }

    //    [DataMember]
    //    public string Nome { get; set; }

    //    [DataMember]
    //    public string ContentType { get; set; }

    //    [DataMember]
    //    public long Tamanho { get; set; }

    //    public string TamanhoFormatadoMB => ((double)Tamanho / 1024000).ToString("N3") + "MB";

    //    public string TamanhoFormatado => Tamanho.BytesToString();

    //    [DataMember]
    //    public Byte[] Conteudo { get; set; }

    //    [DataMember]
    //    public bool Compactado { get; set; }

    //    [DataMember]
    //    public DateTime DataCadastro { get; set; }

    //    [DataMember]
    //    public string Titulo { get; set; }

    //    [DataMember]
    //    public string Descricao { get; set; }

    //    [DataMember]
    //    public int Ordem { get; set; }

    //    [DataMember]
    //    public string ExtensoesPermitidasArquivosAnexosPattern { get; set; }

    //    [DataMember]
    //    public int TamanhoMaximoKBytesArquivosAnexos { get; set; }

    //    [DataMember]
    //    public string NomeUsuarioCriacao { get; set; }

    //    [DataMember]
    //    public string NomeUsuarioAtualizacao { get; set; }

    //    [DataMember]
    //    public DateTime? DataCriacao { get; set; }

    //    [DataMember]
    //    public string NomeUnidadeCriacao { get; set; }

    //    [DataMember]
    //    public DateTime? DataAtualizacao { get; set; }

    //    [DataMember]
    //    public string NomeUnidadeAtualizacao { get; set; }

    //    [DataMember]
    //    public string CodigoAutenticacao { get; set; }

    //    [DataMember]
    //    public bool ConteudoEmStorageExterno { get; set; } // ConteudoEmStorageExterno
    //    [DataMember]
    //    public string UrlStorageExterno { get; set; } // UrlStorageExterno (length: 2000)

    //    [DataMember]
    //    public string NomeIdentificadorStorageExterno { get; set; }

    //    [DataMember]
    //    public string Origem { get; set; }

    //    public bool Assinado { get; set; }

    //    public bool AssinadoPorOutro { get; set; }

    //    public bool Autenticado => !string.IsNullOrEmpty(CodigoAutenticacao);

    //    [DataMember]
    //    public DateTime? DataValidade { get; set; }

    //    [DataMember]
    //    public bool Publico { get; set; }

    //    [DataMember]
    //    public Guid? IdArquivoAnexoGrupo { get; set; }

    //    [DataMember]
    //    public ArquivosAnexosGruposEntity Grupo { get; set; }

    //    [DataMember]
    //    public List<ArquivosAnexosAssinaturasEntity> Assinaturas { get; set; }

    //    [DataMember]
    //    public bool VerificarConfiguracaoStorageExterno { get; set; }

    //    [DataMember]
    //    public bool PossuiImagemAssinaturaCapturada { get; set; }

    //    [DataMember]
    //    public bool Obrigatorio { get; set; }

    //    [DataMember]
    //    public string Base64 { get; set; }

    //    [DataMember]
    //    public int Ordenacao { get; set; }

    //    [DataMember]
    //    public bool Selecionado { get; set; }

    //    [DataMember]
    //    public bool ArquivoComSenha { get; set; }

    //    /// <summary>
    //    /// Propriedade utilizada somente na interface de usuário, para ocultar ou exibir assinaturas
    //    /// </summary>
    //    [DataMember]
    //    public bool ExibirAssinaturas { get; set; }

    //    [DataMember]
    //    public string SituacaoDocumentoVinculado { get; set; }

    //    [DataMember]
    //    public bool DocumentoCancelado { get; set; }
    //}
}
