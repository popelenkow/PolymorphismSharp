using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo21.Implementations
{
    class DoA2B1 : MethodDo21<A2, B1>
    {
        public override void Call(A2 model2, int arg, B1 model1)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}