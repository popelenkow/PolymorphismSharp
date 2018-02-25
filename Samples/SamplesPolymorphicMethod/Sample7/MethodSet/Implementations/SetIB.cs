using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodSet.Implementations
{
    class SetIB : PolymorphicMethod, IMethodSet<IB>
    {
        public void Call(IB model, int arg)
        {
            model.PropertyB = arg;
            Console.WriteLine(model.GetType().Name + " call before " + this.GetType().Name);
            NextMethod.Call(model, arg);
            Console.WriteLine(model.GetType().Name + " call after " + this.GetType().Name);
        }
    }
}