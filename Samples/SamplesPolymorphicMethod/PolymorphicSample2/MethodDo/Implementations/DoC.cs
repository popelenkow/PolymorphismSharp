using System;
using Sample.Parameters;

namespace Sample.MethodDo.Implementations
{
    public class DoC : MethodDo<C>
    {
        public override void Call(C parameter, object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            CallNextMethod();
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}