using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoCB : PolymorphicMethod, IMethodDo<CB>
    {
        public void Before(CB model, params object[] args)
        {
            Console.WriteLine("Before: method " + this.GetType().Name);
        }
        public void After(CB model, params object[] args)
        {
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}