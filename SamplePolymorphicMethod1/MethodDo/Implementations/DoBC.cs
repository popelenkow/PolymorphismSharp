using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoBC : PolymorphicMethod, IMethodDo<BC>
    {
        public void Call(BC model, params object[] args)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
            CallNextMethod();
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}