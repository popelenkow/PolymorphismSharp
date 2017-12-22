using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;

namespace Sample.MethodRead.Implementations
{
    class ReadIB : PolymorphicMethod<string>, IMethodRead<IB>
    {
        public void Before(IB model)
        {
        }
        public void After(IB model)
        {
            this.Result += " PropertyB " + model.PropertyB;
        }
    }
}
