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
    public partial class InstituicoesEnsinoCursosEntity : BaseEntity
    {

        #region  Auto

        

        

        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdInstituicaoEnsinoCurso;
            }
            set
            {
                IdInstituicaoEnsinoCurso = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[InstituicoesEnsinoCursos]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdInstituicaoEnsinoCurso { get; set; }



        [DataMember]
        [Required]
        public Guid IdInstituicaoEnsino { get; set; }



        [DataMember]
        [Required]
        public Guid IdCurso { get; set; }

        #endregion


        #region Partial
        [DataMember]
        public CursosEntity Curso { get; set; }



        #endregion
    }
}
