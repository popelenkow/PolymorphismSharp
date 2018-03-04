using System;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    public class DoC : MethodDo<C>
    {
        public override void Call(C parameter, params object[] args)
        {
            Console.WriteLine("Method " + this.GetType().Name);
        }
    }
}