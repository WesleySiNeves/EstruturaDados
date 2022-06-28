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
    public partial class CursosNiveisEntity : BaseEntity , ISincronizavelFederalEntity
    {

        #region Auto

        

       
        [DataMember]
        public override Guid Id
        {
            get
            {
                return IdNivelCurso;
            }
            set
            {
                IdNivelCurso = value;
            }
        }




        /// <summary>
        /// Campo chave para tabela [Cadastro].[CursosNiveis]
        /// </summary>
        [DataMember]
        [Required]
        public Guid IdNivelCurso { get; set; }




        /// <summary>
        /// Tamanho maximo 200 caracteres
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }



        [DataMember]
        [Required]
        public bool Ativo { get; set; }




        /// <summary>
        /// Tamanho maximo 50 caracteres
        /// </summary>
        [DataMember]
        [StringLength(50)]
        public string CodigoIntegracaoFederal { get; set; }

        #endregion


        #region Partial

        public CursosNiveisEntity()
        {
            Ativo = true;
        }

        public void Inativar()
        {
            Ativo = false;
        }

        #endregion
    }
}
