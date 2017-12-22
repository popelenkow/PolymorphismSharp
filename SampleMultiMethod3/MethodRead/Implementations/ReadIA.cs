using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodRead.Implementations
{
    class ReadIA : IMethodRead<IA>
    {
        public string Call(IA model)
        {
            return "PropertyA " + model.PropertyA;
        }
    }
}
