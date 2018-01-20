using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;
using Sample.Results;
using Sample.Args;

namespace Sample.MethodDo
{
    interface IMethodDo<TModel> : IPolymorphicMethod<IResult>
        where TModel : IA
    {
        IResult Call(TModel model, IArg arg);
    }
}
