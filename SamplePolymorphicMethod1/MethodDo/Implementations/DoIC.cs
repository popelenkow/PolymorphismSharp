using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoIC : PolymorphicMethod, IMethodDo<IC>
    {
        public void Before(IC model, params object[] args)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
        }
        public void After(IC model, params object[] args)
        {
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}