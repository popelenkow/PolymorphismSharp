using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Parametric.Dispatchers;
using PolymorphismSharp.Methods;

namespace Sample.MethodDo21
{
    static class ExtentionsMethodDo21
    {
        private static IMethodDo21<IA2, IA1> _method;
        static ExtentionsMethodDo21()
        {
            _method = GeneralizedMethodBuilder.GetPolymorphicMethod<IMethodDo21<IA2, IA1>>();
        }
        public static void Do21(this IA1 model1, IA2 model2, int arg)
        {
            _method.Call(model2, arg, model1);
        }
    }
}
