using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Parametric.Dispatchers;
using PolymorphismSharp.Methods;

namespace Sample.MethodRead
{
    static class ExtentionsMethodRead
    {
        private static IMethodRead<IA> _method;
        static ExtentionsMethodRead()
        {
            _method = GeneralizedMethodBuilder.GetMultiMethod<IMethodRead<IA>>();
        }
        public static string Read(this IA model)
        {
            return _method.Call(model);
        }
    }
}
