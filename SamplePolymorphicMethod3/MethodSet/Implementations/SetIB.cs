using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;


namespace Sample.MethodSet.Implementations
{
    class SetIB : PolymorphicMethod, IMethodSet<IB>
    {
        public void Before(IB model, int arg)
        {
            model.PropertyB = arg;
            Console.WriteLine(model.GetType().Name + " call before " + this.GetType().Name);
        }
        public void After(IB model, int arg)
        {
            Console.WriteLine(model.GetType().Name + " call after " + this.GetType().Name);
        }
    }
}