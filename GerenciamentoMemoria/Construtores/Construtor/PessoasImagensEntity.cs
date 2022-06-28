using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;
using Construtores.Util;

namespace Construtores.Construtor
{
    public class PessoasImagensEntity : BaseEntity
    {
		#region Auto

		[DataMember]
        public override Guid Id
        {
            get
            {
                return IdPessoaImagem;
            }
            set
            {
                IdPessoaImagem = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[PessoasImagens]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdPessoaImagem { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }




        /// <summary>
        /// Tamanho maximo 150 caracteres
        /// </summary>
        [DataMember]
        [StringLength(150)]
        public string Tipo { get; set; }




        /// <summary>
        /// Texto livre
        /// </summary>
        [DataMember]
        public string Descricao { get; set; }




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
        public DateTime? DataAtualizacao { get; set; }

        #endregion

        #region Partial


        public PessoasImagensEntity()
        {
            //ArquivoAnexo = new ArquivosAnexosEntity();
            ExisteImagem = false;
            IsDigitalizacao = false;
        }

        public PessoaImagemTipo PessoaImagemTipo
        {
            get
            {
                Enum.TryParse(Tipo, out PessoaImagemTipo retorno);
                return retorno;
            }
            set => Tipo = value.ToString();
        }

        //[DataMember]
        //public ArquivosAnexosEntity ArquivoAnexo { get; set; }

        [DataMember]
        public string TipoDescription { get; set; }

        [DataMember]
        public string Url { get; set; }

        [DataMember]
        public bool ExisteImagem { get; set; }

        [DataMember]
        public bool IsDigitalizacao { get; set; }

        #endregion
    }
}
