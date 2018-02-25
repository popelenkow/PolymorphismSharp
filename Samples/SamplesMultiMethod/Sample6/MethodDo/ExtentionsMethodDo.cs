using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Parametric.Dispatchers;
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
        public static string Do(this IA model, int argInt, double argDouble)
        {
            return _method.Call(model, argInt, argDouble);
        }
    }
}
