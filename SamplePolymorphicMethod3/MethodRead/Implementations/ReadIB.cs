using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;

namespace Sample.MethodRead.Implementations
{
    class ReadIB : PolymorphicMethod<string>, IMethodRead<IB>
    {
        public string Call(IB model)
        {
            var result = CallNextMethod();
            return result + " PropertyB " + model.PropertyB;
        }
    }
}
