using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Construtores.Util;

namespace Construtores.Base
{
    public class BaseEntity
    {
        [DataMember]
        public virtual Guid Id { get; set; }

        [DataMember]
        public EntityAction Acao { get; set; }

        //public virtual ActionReturn ValidateDataAnnotationsAttributes()
        //{
        //    var results = new List<ValidationResult>();

        //    var context = new ValidationContext(this, null, null);

        //    var retorno = new ActionReturn();

        //    if (!Validator.TryValidateObject(this, context, results, true))
        //    {
        //        foreach (var error in results)
        //        {
        //            retorno.AdicionarMensagem(error.ErrorMessage, MensagemTipo.Erro);
        //        }
        //    }

        //    return retorno;
        //}
    }
}
