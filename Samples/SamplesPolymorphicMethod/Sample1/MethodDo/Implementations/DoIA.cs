using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoIA : PolymorphicMethod, IMethodDo<IA>
    {
        public void Call(IA model, params object[] args)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}
