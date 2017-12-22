using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodDo.Implementations
{
    class DoIE : IMethodDo<IE>
    {
        public string Call(IE model, int argInt, double argDouble)
        {
            Console.WriteLine(model.GetType().Name + " call " + this.GetType().Name);
            return (argDouble + (double)argInt).ToString();
        }
    }
}