using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;


namespace Sample.MethodDo.Implementations
{
    class DoA1 : IMethodDo<A1>
    {
        public string Call(A1 model, double arg)
        {
            return "DoA1 " + (arg + 3).ToString();
        }
    }
}