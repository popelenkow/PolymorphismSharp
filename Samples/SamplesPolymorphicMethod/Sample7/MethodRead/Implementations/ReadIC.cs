using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodRead.Implementations
{
    class ReadIC : PolymorphicMethod, IMethodRead<IC>
    {
        public string Call(IC model)
        {
            var result = NextMethod.Call(model) as string;
            return result + " PropertyC " + model.PropertyC;
        }
    }
}
