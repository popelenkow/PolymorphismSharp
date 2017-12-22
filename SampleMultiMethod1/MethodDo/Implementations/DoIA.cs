using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodDo.Implementations
{
    class DoIA : IMethodDo<IA>
    {
        public string Call(IA model, double arg)
        {
            return "DoIA 0";
        }
    }
}
