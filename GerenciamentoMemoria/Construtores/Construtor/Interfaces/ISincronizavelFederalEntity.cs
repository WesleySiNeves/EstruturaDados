using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Construtor.Interfaces
{
    public interface ISincronizavelFederalEntity
    {
        Guid Id { get; set; }
        string CodigoIntegracaoFederal { get; set; }
        void Inativar();
    }
}
