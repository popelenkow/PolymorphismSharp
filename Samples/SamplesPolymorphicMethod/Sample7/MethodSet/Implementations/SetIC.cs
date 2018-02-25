using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Methods;


namespace Sample.MethodSet.Implementations
{
    class SetIC : PolymorphicMethod, IMethodSet<IC>
    {
        public void Call(IC model, int arg)
        {
            model.PropertyC = arg-100;
            Console.WriteLine(model.GetType().Name + " call before " + this.GetType().Name);
            NextMethod.Call(model, arg);
            Console.WriteLine(model.GetType().Name + " call after " + this.GetType().Name);
        }
    }
}