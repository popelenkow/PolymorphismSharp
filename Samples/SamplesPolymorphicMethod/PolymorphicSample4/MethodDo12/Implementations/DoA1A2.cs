using System;
using System.Collections.Generic;
using System.Text;
using Sample.Parameters;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo12.Implementations
{
    class DoA1A2 : MethodDo12<A1, A2>
    {
        public override void Call(A1 parameter1, A2 parameter2, int arg)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            CallNextMethod();
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}
