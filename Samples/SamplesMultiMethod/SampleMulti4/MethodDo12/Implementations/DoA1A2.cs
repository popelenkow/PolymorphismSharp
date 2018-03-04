using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo12.Implementations
{
    class DoA1A2 : MethodDo12<A1, A2>
    {
        public override void Call(A2 model2, int arg, A1 model1)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}
