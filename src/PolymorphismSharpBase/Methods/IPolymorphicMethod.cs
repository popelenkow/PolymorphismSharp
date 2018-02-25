using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Callables;

namespace PolymorphismSharp.Methods
{
    public interface IPolymorphicMethod : IGeneralizedMethod
    {
        ICallable NextMethod { get; set; }
    }
}
