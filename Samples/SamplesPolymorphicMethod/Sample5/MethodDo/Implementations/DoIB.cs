using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoIB : PolymorphicMethod, IMethodDo<IB>
    {
        public void Call(IB model, params object[] args)
        {
            var r = new Random();
            var n = r.NextDouble();
            bool success = n > 0.5;
            string nameSuccess = success ? "Success" : "Fail";
            Console.WriteLine("Before: method " + this.GetType().Name + " try call next... " + nameSuccess);
            if (success) NextMethod.Call(model, args);
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}
