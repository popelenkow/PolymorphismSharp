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
    static class ExtensionMethodDo
    {
        private static IMethodDo<IA> _method;
        static ExtensionMethodDo()
        {
            _method = PolymorphicMethodBuilder.GetMethod<IMethodDo<IA>>();
        }

        public static IResult Do(this IA model, IArg arg)
        {
            return _method.Call(model, arg);
        }
    }
}
