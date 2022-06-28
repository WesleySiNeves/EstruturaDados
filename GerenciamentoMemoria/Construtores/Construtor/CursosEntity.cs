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
    public partial class CursosEntity : BaseEntity
    {

        #region Auto

        

        
        [DataMember]
        public override Guid Id
        {
            get { return IdCurso; }
            set { IdCurso = value; }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[Cursos]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdCurso { get; set; }




        /// <summary>
        /// Tamanho maximo 200 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }



        [DataMember] [Required] public bool Ativo { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string NomeUsuarioChancela { get; set; }



        [DataMember] public DateTime? DataChancela { get; set; }




        /// <summary>
        /// Tamanho maximo 250 caracteres
        /// </summary>
        [DataMember]
        [StringLength(250)]
        public string JustificativaChancela { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string CodigoIntegracaoFederal { get; set; }

        #endregion


        #region Partial

        public CursosEntity()
        {
            Ativo = true;
            Niveis = new List<CursosCursosNiveisEntity>();
        }

        [DataMember]
        public List<CursosCursosNiveisEntity> Niveis { get; set; }

        public void Inativar()
        {
            Ativo = false;
        }

        #endregion
    }
}
