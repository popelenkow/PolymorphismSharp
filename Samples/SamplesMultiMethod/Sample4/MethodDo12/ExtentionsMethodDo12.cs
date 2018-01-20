using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Dispatchers;

namespace Sample.MethodDo12
{
    static class ExtentionsMethodDo12
    {
        private static DispatcherMultiMethod<IMethodDo12<IA1, IA2>> Dispatcher { get; set; }
        static ExtentionsMethodDo12()
        {
            Dispatcher = new DispatcherMultiMethod<IMethodDo12<IA1, IA2>>();
        }
        public static void Do12(this IA1 model1, IA2 model2, int arg)
        {
            Dispatcher.GetMethod(model1, model2)
                      .Call(model2, arg, model1);
        }
    }
}
