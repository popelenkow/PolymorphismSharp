using PolymorphismSharp.Static.Callables;
using PolymorphismSharp.Static.Methods;
using System;
using System.Linq;

using System.Collections.Generic;
using System.Text;

namespace PolymorphismSharp.Static.Dispatchers
{
    public class DispatcherMultiMethod<TMethod> : DispatcherGeneralizedMethod<IMultiMethod, TMethod>
        where TMethod : class, IMultiMethod
    {
        public override ICallable<IMultiMethod> GetMethod(params object[] argGenerics)
        {
            var ms = GetMethods(argGenerics);
            IMultiMethod m = (ms.Count() == 0) ? null : ms.First();
            return new MultiCall(m);
        }
    }
    public class DispatcherMultiMethod<TMethod, TResult> : DispatcherGeneralizedMethod<IMultiMethod<TResult>, TMethod, TResult>
        where TMethod : class, IMultiMethod<TResult>
    {
        public override ICallable<IMultiMethod<TResult>, TResult> GetMethod(params object[] argGenerics)
        {
            var ms = GetMethods(argGenerics);
            IMultiMethod<TResult> m = (ms.Count() == 0) ? null : ms.First();
            return new MultiCall<TResult>(m);
        }
    }
}
