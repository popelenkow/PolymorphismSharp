using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodDo.Implementations
{
    class DoBBase : IMethodDo<BBase>
    {
        public string Call(BBase model, double arg)
        {
            return "DoBBase " + arg.ToString();
        }
    }
}