using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Extentions;
using System.Linq;
using PolymorphismSharp.Static.Methods;
using PolymorphismSharp.Static.Callables;


namespace PolymorphismSharp.Static.Dispatchers
{
    public abstract class DispatcherGeneralizedMethod<TGeneralized, TMethod> : DispatcherGeneralizedMethodBase<TGeneralized, TMethod>
        where TGeneralized : class, IGeneralizedMethod
        where TMethod : TGeneralized
    {
        public abstract ICallable<TGeneralized> GetMethod(params object[] argGenerics);
    }
    public abstract class DispatcherGeneralizedMethod<TGeneralized, TMethod, TResult> : DispatcherGeneralizedMethodBase<TGeneralized, TMethod>
       where TGeneralized : class, IGeneralizedMethod
       where TMethod : TGeneralized
    {
        public abstract ICallable<TGeneralized, TResult> GetMethod(params object[] argGenerics);
    }
}
