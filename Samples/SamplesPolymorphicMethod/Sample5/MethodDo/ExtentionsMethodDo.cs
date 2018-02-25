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
            _method = GeneralizedMethodBuilder.GetPolymorphicMethod<IMethodDo<IA>>();
        }

        public static void Do(this IA model, params object[] args)
        {
            _method.Call(model, args);
        }
    }
}
