using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodRead.Implementations
{
    class ReadIA : PolymorphicMethod,  IMethodRead<IA>
    {
        public string Call(IA model)
        {
            var result = NextMethod.Call(model) as string;
            return result + " PropertyA " + model.PropertyA;
        }
    }
}
