using System;
using System.Collections.Generic;
using System.Text;
using Sample.Parameters;
using PolymorphismSharp.Methods;


namespace Sample.MethodDo12.Implementations
{
    class DoB1B2 : MethodDo12<B1, B2>
    {
        public override void Call(B1 parameter1, B2 parameter2, int arg)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}
