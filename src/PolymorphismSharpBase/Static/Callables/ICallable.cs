using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;

namespace PolymorphismSharp.Static.Callables
{
    public interface ICallable<TGeneralized>
        where TGeneralized : IGeneralizedMethod
    {
        void Call(params object[] args);
    }
    public interface ICallable<TGeneralized, TResult>
        where TGeneralized : IGeneralizedMethod
    {
        TResult Call(params object[] args);
    }
}
