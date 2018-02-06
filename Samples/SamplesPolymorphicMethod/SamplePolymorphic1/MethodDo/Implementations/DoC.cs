using System;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    public class DoC : MethodDoBase<C>
    {
        public override void Call(C model, params object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            CallNextMethod();
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}