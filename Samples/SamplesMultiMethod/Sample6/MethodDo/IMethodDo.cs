using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Methods;
using Sample.Models;

namespace Sample.MethodDo
{
    public interface IMethodDo<TModel> : IMultiMethod
        where TModel : IA
    {
        string Call(TModel model, int argInt, double argDouble);
    }
}
