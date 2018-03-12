using System;
using System.Collections.Generic;
using System.Text;
using Sample.Parameters;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo12.Implementations
{
    class DoA1B2 : MethodDo12<A1, B2>
    {
        public override void Call(A1 parameter1, B2 parameter2, int arg)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            CallNextMethod();
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}
