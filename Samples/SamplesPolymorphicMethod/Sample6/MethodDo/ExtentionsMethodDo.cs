using System;
using System.Collections.Generic;
using System.Text;
using Sample.Models;
using PolymorphismSharp.Static.Dispatchers;
using Sample.Results;
using Sample.Args;

namespace Sample.MethodDo
{
    static class ExtentionsMethodDo
    {
        private static DispatcherPolymorphicMethod<IMethodDo<IA>, IResult> Dispatcher { get; set; }
        static ExtentionsMethodDo()
        {
            Dispatcher = new DispatcherPolymorphicMethod<IMethodDo<IA>, IResult>();
        }
        public static IResult Do(this IA model, IArg arg)
        {
            return Dispatcher.GetMethod(model)
                             .Call(model, arg);
        }
    }
}
