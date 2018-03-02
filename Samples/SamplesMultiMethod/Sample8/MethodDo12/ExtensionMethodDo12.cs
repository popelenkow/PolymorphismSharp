using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Parametric.Dispatchers;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo12
{
    static class ExtensionMethodDo12
    {
        private static IMethodDo12<IA1, IA2> _method;
        static ExtensionMethodDo12()
        {
            _method = MultiMethodBuilder.GetMethod<IMethodDo12<IA1, IA2>>();
        }
        public static void Do12(this IA1 model1, IA2 model2, int arg)
        {
            _method.Call(model2, arg, model1);
        }
    }
}
