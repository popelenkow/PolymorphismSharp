using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo21.Implementations
{
    class DoA2A1 : MethodDo21<A2, A1>
    {
        public override void Call(A2 parameter2, int arg, A1 parameter1)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}