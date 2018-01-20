using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodSet.Implementations
{
    class SetIB : IMethodSet<IB>
    {
        public void Call(IB model, int arg)
        {
            model.PropertyA = arg;
            model.PropertyB = arg;
            Console.WriteLine(model.GetType().Name + " call " + this.GetType().Name);
        }
    }
}