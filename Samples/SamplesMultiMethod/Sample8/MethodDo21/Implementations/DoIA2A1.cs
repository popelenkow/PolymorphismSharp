using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;


namespace Sample.MethodDo21.Implementations
{
    public class DoIA2A1 : IMethodDo21<IA2, A1>
    {
        public void Call(IA2 model2, int arg, A1 model1)
        {
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call " + this.GetType().Name);
        }
    }
}
