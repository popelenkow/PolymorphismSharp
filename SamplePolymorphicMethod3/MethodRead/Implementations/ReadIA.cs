using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;

namespace Sample.MethodRead.Implementations
{
    class ReadIA : PolymorphicMethod<string>,  IMethodRead<IA>
    {
        public void Before(IA model)
        {
        }
        public void After(IA model)
        {
            this.Result += " PropertyA " + model.PropertyA;
        }
    }
}
