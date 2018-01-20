using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Dispatchers;

namespace Sample.MethodSet
{
    static class ExtentionsMethodSet
    {
        private static DispatcherPolymorphicMethod<IMethodSet<IA>> Dispatcher { get; set; }
        static ExtentionsMethodSet()
        {
            Dispatcher = new DispatcherPolymorphicMethod<IMethodSet<IA>>();
        }
        public static void Set(this IA model, int arg)
        {
            Dispatcher.GetMethod(model)
                      .Call(model, arg);
        }
    }
}
