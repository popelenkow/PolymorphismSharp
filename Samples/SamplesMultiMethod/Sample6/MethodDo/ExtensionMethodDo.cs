using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Parametric.Dispatchers;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo
{
    static class ExtensionMethodDo
    {
        private static IMethodDo<IA> _method;
        static ExtensionMethodDo()
        {
            _method = MultiMethodBuilder.GetMethod<IMethodDo<IA>>();
        }
        public static string Do(this IA model, int argInt, double argDouble)
        {
            return _method.Call(model, argInt, argDouble);
        }
    }
}
