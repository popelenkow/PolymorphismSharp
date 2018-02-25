using System;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    public class DoC : MethodDoBase<C>
    {
        public override void Call(C model, params object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name + " before");
            NextMethod.Call(model, args);
            Console.WriteLine("Method " + this.GetType().Name + " after");
        }
    }
}