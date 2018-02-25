using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;

namespace Sample.MethodRead.Implementations
{
    class ReadIB : PolymorphicMethod, IMethodRead<IB>
    {
        public string Call(IB model)
        {
            var result = NextMethod.Call(model) as string;
            return result + " PropertyB " + model.PropertyB;
        }
    }
}
