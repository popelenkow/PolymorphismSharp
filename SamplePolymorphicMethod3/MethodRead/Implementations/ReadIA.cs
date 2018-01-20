using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;

namespace Sample.MethodRead.Implementations
{
    class ReadIA : PolymorphicMethod<string>,  IMethodRead<IA>
    {
        public string Call(IA model)
        {
            var result = CallNextMethod();
            return result + " PropertyA " + model.PropertyA;
        }
    }
}
