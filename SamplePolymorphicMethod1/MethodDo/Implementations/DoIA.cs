using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoIA : PolymorphicMethod, IMethodDo<IA>
    {
        public void Before(IA model, params object[] args)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
        }
        public void After(IA model, params object[] args)
        {
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}
