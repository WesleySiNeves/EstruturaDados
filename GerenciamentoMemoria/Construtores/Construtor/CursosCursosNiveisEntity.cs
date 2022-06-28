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
    public partial class CursosCursosNiveisEntity : BaseEntity
    {

        #region Auto

        

        
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdCursoCursoNivel;
            }
            set
            {
                IdCursoCursoNivel = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[CursosCursosNiveis]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdCursoCursoNivel { get; set; }



        [DataMember]
        [Required]
        public Guid IdCurso { get; set; }



        [DataMember]
        [Required]
        public Guid IdNivelCurso { get; set; }

        #endregion


        #region Partial

        [DataMember]
        public CursosNiveisEntity CursoNivel { get; set; }

        #endregion
    }
}
