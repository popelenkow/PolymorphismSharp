using System;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    public class DoA : MethodDoBase<A>
    {
        public override void Call(A model, params object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}
