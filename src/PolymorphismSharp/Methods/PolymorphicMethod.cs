using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Methods
{
    public abstract class PolymorphicMethod<TMethod> : IGeneralizedMethod
        where TMethod : PolymorphicMethod<TMethod>
    {
        public TMethod NextMethod { get; set; }
    }
}
