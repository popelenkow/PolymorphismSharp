using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo12.Implementations
{
    class DoB1A2 : MethodDo12<B1, A2>
    {
        public override void Call(A2 parameter2, int arg, B1 parameter1)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            NextMethod.Call(parameter2, arg, parameter1);
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}
