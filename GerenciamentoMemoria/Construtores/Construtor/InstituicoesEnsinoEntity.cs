using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Base;
using Construtores.Construtor.Interfaces;

namespace Construtores.Construtor
{
    [DataContract]
    [Serializable]
    public class InstituicoesEnsinoEntity : BaseEntity  , ISincronizavelFederalEntity
    {
        #region Auto


        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdInstituicaoEnsino;
            }
            set
            {
                IdInstituicaoEnsino = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[InstituicoesEnsino]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdInstituicaoEnsino { get; set; }



        [DataMember]
        [Required]
        public Guid IdPessoa { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string Codigo { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string Reitor { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string CodigoIntegracaoFederal { get; set; }

        #endregion


        #region  Partial


        public InstituicoesEnsinoEntity()
        {

            Campus = new List<InstituicoesEnsinoCampusEntity>();
            Cursos = new List<InstituicoesEnsinoCursosEntity>();
        }


        [DataMember]
        public List<InstituicoesEnsinoCampusEntity> Campus { get; set; }

        [DataMember]
        public List<InstituicoesEnsinoCursosEntity> Cursos { get; set; }

        public void Inativar()
        {
            // Não existe o campo "Ativo" para a instituição de ensino
        }

        #endregion
    }
}
