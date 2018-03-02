using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo12.Implementations
{
    class DoB1B2 : MethodDo12Base<B1, B2>
    {
        public override void Call(B2 model2, int arg, B1 model1)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            NextMethod.Call(model2, arg, model1);
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}
