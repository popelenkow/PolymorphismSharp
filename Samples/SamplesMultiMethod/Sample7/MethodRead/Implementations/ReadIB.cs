using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodRead.Implementations
{
    class ReadIB : IMethodRead<IB>
    {
        public string Call(IB model)
        {
            return "PropertyA " + model.PropertyA + " PropertyB " + model.PropertyB;
        }
    }
}