using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Callables;

namespace PolymorphismSharp.Methods
{
    public abstract class PolymorphicMethod : IPolymorphicMethod
    {
        public ICallable NextMethod { get; set; }

    }
}
