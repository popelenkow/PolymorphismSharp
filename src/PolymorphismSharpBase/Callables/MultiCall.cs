using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;

namespace PolymorphismSharp.Callables
{
    class MultiCall : ICallable
    {
        public (Type Interface, Type Implementation) Pair { get; set; }
        public MultiCall((Type Interface, Type Implementation) pair)
        {
            Pair = pair;
        }
        public object Call(params object[] args)
        {
            var instance = Activator.CreateInstance(Pair.Implementation) as IMultiMethod; 
            return Pair.Interface.GetMethod("Call").Invoke(instance, args);
        }
    }
}
