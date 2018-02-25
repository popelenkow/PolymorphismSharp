using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;
using Sample.Results;
using Sample.Args;

namespace Sample.MethodDo
{
    public interface IMethodDo<TModel> : IPolymorphicMethod
        where TModel : IA
    {
        IResult Call(TModel model, IArg arg);
    }
}
