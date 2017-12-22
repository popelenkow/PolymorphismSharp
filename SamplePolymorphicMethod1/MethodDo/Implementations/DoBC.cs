using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoBC : PolymorphicMethod, IMethodDo<BC>
    {
        public void Before(BC model, params object[] args)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
        }
        public void After(BC model, params object[] args)
        {
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}