using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;

namespace Sample.MethodRead.Implementations
{
    class ReadIC : PolymorphicMethod<string>, IMethodRead<IC>
    {
        public void Before(IC model)
        {
        }
        public void After(IC model)
        {
            this.Result += " PropertyC " + model.PropertyC;
        }
    }
}
