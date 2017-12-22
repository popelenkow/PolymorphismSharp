using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Dispatchers;

namespace Sample.MethodDo
{
    static class ExtentionsMethodDo
    {
        private static DispatcherPolymorphicMethod<IMethodDo<IA>> Dispatcher { get; set; }
        static ExtentionsMethodDo()
        {
            Dispatcher = new DispatcherPolymorphicMethod<IMethodDo<IA>>();
        }
        public static void Do(this IA model, params object[] args)
        {
            Dispatcher.GetMethod(model)
                      .Call(model, args);
        }
    }
}
