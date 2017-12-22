using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;


namespace Sample.MethodDo21.Implementations
{
    class DoIA2A1 : PolymorphicMethod, IMethodDo21<IA2, A1>
    {
        public void Before(IA2 model2, int arg, A1 model1)
        {
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call before " + this.GetType().Name);
        }
        public void After(IA2 model2, int arg, A1 model1)
        {
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call after " + this.GetType().Name);
        }
    }
}