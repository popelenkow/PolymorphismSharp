using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Methods;


namespace Sample.MethodDo12.Implementations
{
    class DoIA1IA2 : PolymorphicMethod, IMethodDo12<IA1, IA2>
    {
        public void Before(IA2 model2, int arg, IA1 model1)
        {
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call before " + this.GetType().Name);
        }
        public void After(IA2 model2, int arg, IA1 model1)
        {
            Console.WriteLine("Classes " + model1.GetType().Name + " " + model2.GetType().Name + " call after " + this.GetType().Name);
        }
    }
}
