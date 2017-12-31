using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;

namespace PolymorphismSharp.Static.Callables
{
    class MultiCall : ICallable<IMultiMethod>
    {
        public IMultiMethod InstanceMethod { get; set; }
        public MultiCall(IMultiMethod instanceMethod)
        {
            InstanceMethod = instanceMethod;
        }
        public void Call(params object[] args)
        {
            var method = InstanceMethod;
            if (method == null) return;
            method.GetType().GetMethod("Call").Invoke(method, args);
        }
    }
    class MultiCall<TResult> : ICallable<IMultiMethod<TResult>, TResult>
    {
        public IMultiMethod<TResult> InstanceMethod { get; set; }
        public MultiCall(IMultiMethod<TResult> instanceMethod)
        {
            InstanceMethod = instanceMethod;
        }
        public TResult Call(params dynamic[] args)
        {
            var method = InstanceMethod;
            if (method == null) return default(TResult);
            return (TResult)method.GetType().GetMethod("Call").Invoke(method, args);
        }
    }
}
