using System;
using System.Collections.Generic;
using System.Text;
using Sample.Parameters;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo21.Implementations
{
    class DoB2B1 : MethodDo21<B2, B1>
    {
        public override void Call(B1 parameter1, B2 parameter2, int arg)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            CallNextMethod();
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}