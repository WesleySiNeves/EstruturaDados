using System;

namespace Construtores.Util
{
    [AttributeUsage(AttributeTargets.All)]
    public class EnumGuidAttribute : Attribute
    {
        //public EnumGuidAttribute(string identificador);
        public Guid Identificador { get; }
    }
}
