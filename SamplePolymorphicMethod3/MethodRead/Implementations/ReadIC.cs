using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;

namespace Sample.MethodRead.Implementations
{
    class ReadIC : PolymorphicMethod<string>, IMethodRead<IC>
    {
        public string Call(IC model)
        {
            var result = CallNextMethod();
            return result + " PropertyC " + model.PropertyC;
        }
    }
}
