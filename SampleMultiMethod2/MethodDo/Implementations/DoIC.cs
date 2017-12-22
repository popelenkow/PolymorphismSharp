using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodDo.Implementations
{
    class DoIC : IMethodDo<IC>
    {
        public string Call(IC model, int argInt, double argDouble)
        {
            Console.WriteLine(model.GetType().Name + " call " + this.GetType().Name);
            return this.GetType().Name + " " + (argDouble + (double)argInt).ToString();
        }
    }
}
