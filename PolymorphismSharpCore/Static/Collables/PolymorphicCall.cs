using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PolymorphismSharp.Static.Methods;

namespace PolymorphismSharp.Static.Callables
{
    class PolymorphicCall : ICallable<IPolymorphicMethod>
    {
        public IEnumerable<IPolymorphicMethod> InstanceMethods { get; set; }
        public PolymorphicCall(IEnumerable<IPolymorphicMethod> instanceMethods)
        {
            InstanceMethods = instanceMethods;
        }
        public void Call(params dynamic[] args)
        {
            var arr = new List<IPolymorphicMethod>();
            foreach (var method in InstanceMethods)
            {
                method.CallNextMethod = true;
                method.GetType().GetMethod("Before").Invoke(method, args);
                arr.Insert(0, method);
                if (!method.CallNextMethod) break;
            }
            foreach (var method in arr)
            {
                method.GetType().GetMethod("After").Invoke(method, args);
            }
        }
    }
    class PolymorphicCall<TResult> : ICallable<IPolymorphicMethod<TResult>, TResult>

    {
        public IEnumerable<IPolymorphicMethod<TResult>> InstanceMethods { get; set; }
        public PolymorphicCall(IEnumerable<IPolymorphicMethod<TResult>> instanceMethods)
        {
            InstanceMethods = instanceMethods;
        }
        public TResult Call(params dynamic[] args)
        {
            var arr = new List<IPolymorphicMethod<TResult>>();
            TResult result = default(TResult);
            foreach (var method in InstanceMethods)
            {
                method.Result = result;
                method.CallNextMethod = true;
                method.GetType().GetMethod("Before").Invoke(method, args);
                arr.Insert(0, method);
                result = method.Result;
                if (!method.CallNextMethod) break;
            }
            foreach (var method in arr)
            {
                method.Result = result;
                method.GetType().GetMethod("After").Invoke(method, args);
                result = method.Result;
            }
            return result;
        }
    }
}
