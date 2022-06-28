using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Construtor.Interfaces
{
    public interface IMonitoravelEntity
    {
        string NomeUsuarioCriacao { get; set; }
        string NomeUsuarioAtualizacao { get; set; }
        DateTime? DataCriacao { get; set; }
        string NomeUnidadeCriacao { get; set; }
        DateTime? DataAtualizacao { get; set; }
        string NomeUnidadeAtualizacao { get; set; }
    }
}
