using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodDo21.Implementations
{
    public class DoA2IA1 : IMethodDo21<A2, IA1>
    {
        public void Call(A2 model2, int arg, IA1 model1)
        {
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call " + this.GetType().Name);
        }
    }
}
