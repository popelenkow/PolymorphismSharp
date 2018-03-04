using System;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    public class DoC : MethodDo<C>
    {
        public override void Call(C model, params object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}