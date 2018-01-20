using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Dispatchers;

namespace Sample.MethodDo
{
    static class ExtentionsMethodDo
    {
        private static DispatcherMultiMethod<IMethodDo<IA>, string> Dispatcher { get; set; }
        static ExtentionsMethodDo()
        {
            Dispatcher = new DispatcherMultiMethod<IMethodDo<IA>, string>();
        }
        public static string Do(this IA model, double arg)
        {
            return Dispatcher.GetMethod(model)
                             .Call(model, arg);
        }
    }
}
