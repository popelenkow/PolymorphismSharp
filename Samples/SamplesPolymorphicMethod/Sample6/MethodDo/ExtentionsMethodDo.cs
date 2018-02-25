using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Parametric.Dispatchers;
using Sample.Results;
using Sample.Args;
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

        public static IResult Do(this IA model, IArg arg)
        {
            return _method.Call(model, arg);
        }
    }
}
