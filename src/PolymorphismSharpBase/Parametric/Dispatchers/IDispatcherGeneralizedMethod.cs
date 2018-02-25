using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Parametric.Extensions;
using System.Linq;
using PolymorphismSharp.Methods;
using PolymorphismSharp.Callables;


namespace PolymorphismSharp.Parametric.Dispatchers
{
    public interface IDispatcherGeneralizedMethod<TMethod>
        where TMethod : IGeneralizedMethod
    {
        ICallable GetMethod(params object[] argGenerics);
    }
}
