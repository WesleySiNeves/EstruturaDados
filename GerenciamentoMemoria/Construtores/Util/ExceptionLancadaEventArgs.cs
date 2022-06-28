using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    public class ExceptionLancadaEventArgs : EventArgs
    {
        public Exception Exception { get; }
        public DateTime Date { get; }
    }
}
