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
            _method = PolymorphicMethodBuilder.GetMethod<IMethodDo<IA>>();
        }

        public static void Do(this IA model, params object[] args)
        {
            _method.Call(model, args);
        }
    }
}
