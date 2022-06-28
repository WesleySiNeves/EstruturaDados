using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores.Util
{
    public class ExtraDescriptionAttribute : Attribute
    {
        private string _value;
        public ExtraDescriptionAttribute(string value)
        {
            _value = value;
        }
        public string Value
        {
            get { return _value; }
        }
    }
}
