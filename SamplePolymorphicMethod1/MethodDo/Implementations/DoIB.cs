using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo.Implementations
{
    class DoIB : PolymorphicMethod, IMethodDo<IB>
    {
        public void Before(IB model, params object[] args)
        {
            var r = new Random();
            var n = r.NextDouble();
            bool success = n > 0.5;
            string nameSuccess = success ? "Success" : "Fail";
            Console.WriteLine("Before: method " + this.GetType().Name + " try call next... " + nameSuccess);
            CallNextMethod = success;
        }
        public void After(IB model, params object[] args)
        {
            Console.WriteLine("After: method " + this.GetType().Name);
        }
    }
}
