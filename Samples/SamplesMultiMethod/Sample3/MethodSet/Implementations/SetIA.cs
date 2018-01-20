using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodSet.Implementations
{
    class SetIA : IMethodSet<IA>
    {
        public void Call(IA model, int arg)
        {
            model.PropertyA = arg + 5;
            Console.WriteLine(model.GetType().Name + " call " + this.GetType().Name);
        }
    }
}
