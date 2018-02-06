using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodDo.Implementations
{
    class DoIA : IMethodDo<IA>
    {
        public string Call(IA model, int argInt, double argDouble)
        {
            Console.WriteLine(model.GetType().Name + " call " + this.GetType().Name);
            return "A.A.A";
        }
    }
}
