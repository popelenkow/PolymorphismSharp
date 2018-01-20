using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Extentions;
using System.Linq;
using PolymorphismSharp.Static.Methods;
using PolymorphismSharp.Static.Callables;

namespace PolymorphismSharp.Static.Dispatchers
{
    public class DispatcherPolymorphicMethod<TMethod> : DispatcherGeneralizedMethodBase<IPolymorphicMethod, TMethod>
        where TMethod : class, IPolymorphicMethod
    {
        public override ICallable<IPolymorphicMethod> GetMethod(params object[] argGenerics)
        {
            return new PolymorphicCall
            {
                Pairs = GetMethods(argGenerics).ToList()
            };
        }
    }
    public class DispatcherPolymorphicMethod<TMethod, TResult> : DispatcherGeneralizedMethodBase<IPolymorphicMethod<TResult>, TMethod, TResult>
        where TMethod : class, IPolymorphicMethod<TResult>
    {
        public override ICallable<IPolymorphicMethod<TResult>, TResult> GetMethod(params object[] argGenerics)
        {
            return new PolymorphicCall<TResult>
            {
                Pairs = GetMethods(argGenerics).ToList()
            };
        }
    }
}
