using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodDo12.Implementations
{
    class DoA1IA2 : IMethodDo12<A1, IA2>
    {
        public void Call(IA2 model2, int arg, A1 model1)
        {
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call " + this.GetType().Name);
        }
    }
}
