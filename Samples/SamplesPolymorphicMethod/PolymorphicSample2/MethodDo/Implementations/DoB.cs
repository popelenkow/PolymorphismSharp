using System;
using Sample.Parameters;

namespace Sample.MethodDo.Implementations
{
    public class DoB : MethodDo<B>
    {
        public override void Call(B parameter, object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            CallNextMethod();
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}
