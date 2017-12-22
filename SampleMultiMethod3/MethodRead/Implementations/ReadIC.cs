using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodRead.Implementations
{
    class ReadIC : IMethodRead<IC>
    {
        public string Call(IC model)
        {
            return "PropertyA " + model.PropertyA + " PropertyB " + model.PropertyB + " PropertyC " + model.PropertyC;
        }
    }
}