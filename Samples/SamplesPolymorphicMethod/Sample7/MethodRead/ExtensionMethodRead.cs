using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Parametric.Dispatchers;
using PolymorphismSharp.Methods;

namespace Sample.MethodRead
{
    static class ExtensionMethodRead
    {
        private static IMethodRead<IA> _method;
        static ExtensionMethodRead()
        {
            _method = PolymorphicMethodBuilder.GetMethod<IMethodRead<IA>>();
        }
        public static string Read(this IA model)
        {
            return _method.Call(model);
        }
    }
}
