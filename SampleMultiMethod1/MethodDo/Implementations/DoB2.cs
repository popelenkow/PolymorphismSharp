using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodDo.Implementations
{
    class DoB2 : IMethodDo<B2>
    {
        public string Call(B2 model, double arg)
        {
            return "DoB2";
        }
    }
}