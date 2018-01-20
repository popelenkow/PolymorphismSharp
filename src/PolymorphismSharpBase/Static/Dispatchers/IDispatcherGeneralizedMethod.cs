using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Extentions;
using System.Linq;
using PolymorphismSharp.Static.Methods;
using PolymorphismSharp.Static.Callables;


namespace PolymorphismSharp.Static.Dispatchers
{
    public interface IDispatcherGeneralizedMethod<TGeneralized, TMethod>
        where TGeneralized : class, IGeneralizedMethod
        where TMethod : TGeneralized
    {
        ICallable<TGeneralized> GetMethod(params object[] argGenerics);
    }
    public interface IDispatcherGeneralizedMethod<TGeneralized, TMethod, TResult> 
       where TGeneralized : class, IGeneralizedMethod
       where TMethod : TGeneralized
    {
        ICallable<TGeneralized, TResult> GetMethod(params object[] argGenerics);
    }
}
