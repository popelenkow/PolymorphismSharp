using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;


namespace Sample.MethodSet.Implementations
{
    class SetIA : PolymorphicMethod, IMethodSet<IA>
    {
        public void Before(IA model, int arg)
        {
            model.PropertyA = arg + 5;
            Console.WriteLine(model.GetType().Name + " call before " + this.GetType().Name);
        }
        public void After(IA model, int arg)
        {
            Console.WriteLine(model.GetType().Name + " call after " + this.GetType().Name);
        }
    }
}
