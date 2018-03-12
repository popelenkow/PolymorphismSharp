using System;
using Sample.Parameters;

namespace Sample.MethodDo.Implementations
{
    public class DoA : MethodDo<A>
    {
        public override void Call(A parameter, object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            CallNextMethod();
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}
