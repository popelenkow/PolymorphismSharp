using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Parametric.Dispatchers;
using PolymorphismSharp.Callables;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo
{
    static class ExtentionsMethodDo
    {
        private static IMethodDo<IA> _method;
        static ExtentionsMethodDo()
        {
            _method = GeneralizedMethodBuilder.GetMultiMethod<IMethodDo<IA>>();
        }
        public static string Do(this IA model, double arg)
        {
            return _method.Call(model, arg) as string;
        }
    }
}
