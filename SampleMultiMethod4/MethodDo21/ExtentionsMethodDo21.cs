using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Dispatchers;

namespace Sample.MethodDo21
{
    static class ExtentionsMethodDo21
    {
        private static DispatcherMultiMethod<IMethodDo21<IA2, IA1>> Dispatcher { get; set; }
        static ExtentionsMethodDo21()
        {
            Dispatcher = new DispatcherMultiMethod<IMethodDo21<IA2, IA1>>();
        }
        public static void Do21(this IA1 model1, IA2 model2, int arg)
        {
            Dispatcher.GetMethod(model2, model1)
                      .Call(model2, arg, model1);
        }
    }
}
