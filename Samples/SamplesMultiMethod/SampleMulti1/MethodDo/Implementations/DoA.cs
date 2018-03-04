using System;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    public class DoA : MethodDo<A>
    {
        public override void Call(A parameter, params object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}
