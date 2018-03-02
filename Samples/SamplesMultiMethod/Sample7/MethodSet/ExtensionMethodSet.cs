using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Parametric.Dispatchers;
using PolymorphismSharp.Methods;

namespace Sample.MethodSet
{
    static class ExtensionMethodSet
    {
        private static IMethodSet<IA> _method;
        static ExtensionMethodSet()
        {
            _method = MultiMethodBuilder.GetMethod<IMethodSet<IA>>();
        }
        public static void Set(this IA model, int arg)
        {
            _method.Call(model, arg);
        }
    }
}
