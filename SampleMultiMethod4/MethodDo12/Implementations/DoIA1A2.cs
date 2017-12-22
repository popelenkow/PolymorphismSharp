using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using Sample.Models;


namespace Sample.MethodDo12.Implementations
{
    class DoIA1A2 : IMethodDo12<IA1, A2>
    {
        public void Call(A2 model2, int arg, IA1 model1)
        {
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call " + this.GetType().Name);
        }
    }
}
