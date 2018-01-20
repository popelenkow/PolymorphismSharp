using System;
using System.Collections.Generic;
using System.Text;
using PolymorphismSharp.Static.Methods;
using Sample.Models;

namespace Sample.MethodDo
{
    interface IMethodDo<TModel> : IMultiMethod<string>
        where TModel : IA
    {
        string Call(TModel model, double arg);
    }
}
